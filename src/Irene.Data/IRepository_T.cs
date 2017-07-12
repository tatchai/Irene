using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irene.Data {
  public interface IRepository<T> where T : class {

    IQueryable<T> Query(Func<T, bool> criteria, bool fromLocal = false);

    T Add(T item);
    T Remove(T item); 
  }
}
