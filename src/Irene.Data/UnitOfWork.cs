using Irene.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irene.Data {
  public class UnitOfWork : IDisposable {

    private AppDb db = new AppDb();

    public UserRepository UserRepository { get; }

    private Dictionary<Type, object> col = new Dictionary<Type, object>();
    private Dictionary<Type, Type> entityToRepos = new Dictionary<Type, Type>();

    public UnitOfWork() {
      entityToRepos.Add(typeof(User), typeof(UserRepository));
      col.Add(typeof(User), new Lazy<UserRepository>(() => new UserRepository(db)));
    }

    public IRepository<T> Repo<T>() where T : class {
      var c = (Lazy<UserRepository>)col[typeof(T)]; // Lazy of Repo
      return (IRepository<T>)c.Value; 
    } 

    public int SaveChanges() { 
      return db.SaveChanges();
    }

    void IDisposable.Dispose() {
      db.Dispose();
    }
  }
}
