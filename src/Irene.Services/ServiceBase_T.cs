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
      _Uow = uow ?? throw new ArgumentNullException(nameof(uow));
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


    //////public DisconnectedList<UserGroup> GetDisconnectedListOf(UserGroup item) {
    //////  Func<UserGroup, bool> condition = x => x.Roles.Any(r => r.Groups.Any(g => g.Id == item.Id));

    //////  var result = new DisconnectedList<UserGroup>() {
    //////    Condition = condition,
    //////    List = Query(condition).ToList()
    //////  };
    //////  return result;
    //////}

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

    public void Sync(ICollection<T> source, ICollection<MapItemInt> mapItems) {
      foreach (var item in mapItems) {
        if (!source.Any(r => r.Id.Equals(item.Id))) {
          var r = Find(item.Id);
          source.Add(r);
        }
      }

      foreach (var item in source.ToList()) {
        if (!mapItems.Any(r => r.Id.Equals(item.Id))) {
          source.Remove(item);
        }
      }
    }
  }
}
