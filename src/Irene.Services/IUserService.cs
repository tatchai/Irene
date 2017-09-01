using Irene.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irene.Services {
  public interface IUserGroupService : IService<UserGroup> {

    IEnumerable<User> AvailableUsersToAddToGroup(UserGroup group);
  }
}
