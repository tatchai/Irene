using Irene.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irene.Services {
  public abstract class ServiceBase<T> : IService<T> where T : class {

    private readonly IRepository<T> _BaseRepo;

    public ServiceBase(IRepository<T> baseRepo) {
      if (baseRepo == null) {
        throw new ArgumentNullException(nameof(baseRepo));
      }
      _BaseRepo = baseRepo;
    }

    public abstract T Find(params object[] keys);

    public virtual T Add(T item) {
      return _BaseRepo.Add(item);
    }

    public virtual IQueryable<T> All(bool fromLocal = false) => Query(_ => true, fromLocal);

    public virtual IQueryable<T> Query(Func<T, bool> criteria, bool fromLocal = false) => _BaseRepo.Query(criteria, fromLocal);

    public virtual T Remove(T item) => _BaseRepo.Remove(item);

    public virtual int SaveChanges() => _BaseRepo.SaveChanges();

  }
}
