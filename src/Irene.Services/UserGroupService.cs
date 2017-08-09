using Irene.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irene.Data;

namespace Irene.Services {
  public class UserGroupService : ServiceBase<UserGroup, int> {
    public UserGroupService(UnitOfWork uow) : base(uow) {
      //
    }
      
  }
}
