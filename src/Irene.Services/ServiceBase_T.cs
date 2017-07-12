using Irene.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irene.Services {
  public abstract class ServiceBase<T> : IService<T> where T : class {
     
    private readonly UnitOfWork _Uow;

    public ServiceBase(UnitOfWork uow) {
      if (uow == null) {
        throw new ArgumentNullException(nameof(uow));
      }
      _Uow = uow;
    }

    public abstract T Find(params object[] keys);

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
  }
}
