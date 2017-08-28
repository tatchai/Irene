using Irene.Data;
using Irene.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irene.Services {
  public abstract class ServiceBase<T, TKey> : IService<T>
      where T : EntityBase<TKey>
      where TKey : IComparable<TKey> {

    private readonly UnitOfWork _Uow;

    public ServiceBase(UnitOfWork uow) {
      if (uow == null) {
        throw new ArgumentNullException(nameof(uow));
      }
      _Uow = uow;
    }

    public virtual T Find(params object[] keys) {
      TKey id = (TKey)keys[0]; 
      return Query(c => c.Id.CompareTo(id) == 0).SingleOrDefault();
    }

    public virtual T Add(T item) {
      return _Uow.Repo<T>().Add(item);
    }

    public virtual IQueryable<T> All(bool fromLocal = false)
      => Query(_ => true, fromLocal);

    public virtual IQueryable<T> Query(Func<T, bool> criteria, bool fromLocal = false)
      => _Uow.Repo<T>().Query(criteria, fromLocal);

    public virtual T Remove(T item) => _Uow.Repo<T>().Remove(item);

    public virtual void OnSaveChanges() {
      //
    }

    public DisconnectedList<T> GetDisconnectedList(Func<T, bool> condition) {
      var result = new DisconnectedList<T>() {
        Condition = condition,
        List = Query(condition).ToList()
      };
      return result;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="disconnectedList"></param>
    public void MergeWithDisconnectedList(DisconnectedList<T> disconnectedList) {
      var origin = Query(disconnectedList.Condition).ToList();

      foreach (var item in disconnectedList.List.Except(origin)) {
        origin.Add(item);
        Add(item);
      }

      // deleted item
      foreach (var item in origin.Except(disconnectedList.List)) {
        Remove(item);
      }
    }
  }
}
