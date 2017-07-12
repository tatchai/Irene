using Irene.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irene.Services {
  public class App : IDisposable {

    private readonly UnitOfWork Uow;

    private Lazy<UserService> _UserService;


    public App() {
      Uow = new UnitOfWork();
      _UserService = new Lazy<UserService>(() => new UserService(Uow));
    }

    public UserService Users => _UserService.Value;

    public int SaveChanges() {
      Users.OnSaveChanges();

      return Uow.SaveChanges();
    }

    void IDisposable.Dispose() {
      ((IDisposable)Uow).Dispose();
    }
  }
}
