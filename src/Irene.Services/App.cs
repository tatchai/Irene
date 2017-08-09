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
    private Lazy<CarService> _CarService; 

    public App() {
      Uow = new UnitOfWork();
      _UserService = new Lazy<UserService>(() => new UserService(Uow));
      _CarService = new Lazy<CarService>(() => new CarService(Uow));
    }

    public UserService Users => _UserService.Value;
    public CarService Cars => _CarService.Value;

    public int SaveChanges() {
      Users.OnSaveChanges();
      Cars.OnSaveChanges();

      return Uow.SaveChanges();
    }

    void IDisposable.Dispose() {
      ((IDisposable)Uow).Dispose();
    }
  }
}
