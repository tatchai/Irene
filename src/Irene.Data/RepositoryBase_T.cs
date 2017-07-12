using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irene.Data {
  public abstract class RepositoryBase<T> : IRepository<T> where T : class {

    private readonly DbContext _context;

    public RepositoryBase(): this(new AppDb()) {
      //
    }
    
    public RepositoryBase(DbContext context) {
      _context = context;
    }

    public T Add(T item) {
      return _context.Set<T>().Add(item);
    }

    public IQueryable<T> Query(Func<T, bool> criteria, bool fromLocal = false) {
      if (fromLocal) {
        return _context.Set<T>().Local.Where(criteria).AsQueryable();
      }
      return _context.Set<T>().Where(criteria).AsQueryable();
    }

    public IQueryable<T> All() {
      return _context.Set<T>().AsQueryable();
    }

    public T Remove(T item) {
      return _context.Set<T>().Remove(item);
    } 
  }
}
