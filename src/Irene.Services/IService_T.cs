using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irene.Services {
  public interface IService<T> where T : class {

    IQueryable<T> All(bool fromLocal = false);
    IQueryable<T> Query(Func<T, bool> criteria, bool fromLocal = false);
    T Add(T item);
    T Remove(T item);

    DisconnectedList<T> GetDisconnectedList(Func<T, bool> condition);
    void MergeWithDisconnectedList(DisconnectedList<T> list);

    void OnSaveChanges();
  }
}
