using Irene.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irene.Data {
  public class UnitOfWork : IDisposable {

    private AppDb db = new AppDb();

    // TODO 1.
    public UserRepository UserRepository { get; }
    public UserGroupRepository UserGroupRepository { get; }
    public RoleRepository RoleRepository { get; }

    private Dictionary<Type, object> col = new Dictionary<Type, object>(); 

    public UnitOfWork() { 
      // TODO 2.
      col.Add(typeof(User), new Lazy<UserRepository>(() => new UserRepository(db)));
      col.Add(typeof(UserGroup), new Lazy<UserGroupRepository>(() => new UserGroupRepository(db)));
      col.Add(typeof(Role), new Lazy<RoleRepository>(() => new RoleRepository(db)));
    }

    public IRepository<T> Repo<T>() where T : class {
      // TODO 3.
      if (typeof(T) == typeof(User)) {
        return (IRepository<T>)((Lazy<UserRepository>)col[typeof(T)]).Value;
      }
      else if (typeof(T) == typeof(UserGroup)) {
        return (IRepository<T>)((Lazy<UserGroupRepository>)col[typeof(T)]).Value;
      }
      else if (typeof(T) == typeof(Role)) {
        return (IRepository<T>)((Lazy<RoleRepository>)col[typeof(T)]).Value;
      }
      return null; 
    }

    public int SaveChanges() {
      return db.SaveChanges();
    }

    void IDisposable.Dispose() {
      db.Dispose();
    }
  }
}
