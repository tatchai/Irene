using Irene.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irene.Data;

namespace Irene.Services {
  public class UserGroupService : ServiceBase<UserGroup, int> , IUserGroupService {
    private readonly UserService userService;

    public UserGroupService(UnitOfWork uow, UserService userService) : base(uow) {
      this.userService = userService;
    }

    public IEnumerable<User> AvailableUsersToAddToGroup(UserGroup group) {
     return userService.All().Except(group.Users).AsEnumerable();
    }
  }
}
