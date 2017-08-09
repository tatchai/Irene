using Irene.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irene.Data;

namespace Irene.Services {
  public class RoleService : ServiceBase<Role, int> {
    public RoleService(UnitOfWork uow) : base(uow) {
      //
    } 
  }
}
