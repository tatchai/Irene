using Irene.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irene.Services {
  public class App : IDisposable {

    private readonly UnitOfWork Uow;

    // TODO 1
    private Lazy<UserService> _UserService;
    private Lazy<IUserGroupService> _UserGroupService;
    private Lazy<RoleService> _RoleService;
    private Lazy<CarService> _CarService; 

    public App() {
      Uow = new UnitOfWork();

      // TODO 2
      _UserService = new Lazy<UserService>(() => new UserService(Uow));
      _UserGroupService = new Lazy<IUserGroupService>(() => new UserGroupService(Uow, Users));
      _RoleService = new Lazy<RoleService>(() => new RoleService(Uow));
      _CarService = new Lazy<CarService>(() => new CarService(Uow));
    }

    // TODO 3
    public UserService Users => _UserService.Value;
    public IUserGroupService UserGroups => _UserGroupService.Value;
    public RoleService Roles => _RoleService.Value;
    public CarService Cars => _CarService.Value;

    public int SaveChanges() {
      // TODO 4
      Users.OnSaveChanges();
      UserGroups.OnSaveChanges();
      Roles.OnSaveChanges();
      Cars.OnSaveChanges();

      return Uow.SaveChanges();
    }

    void IDisposable.Dispose() {
      ((IDisposable)Uow).Dispose();
    }
  }
}
