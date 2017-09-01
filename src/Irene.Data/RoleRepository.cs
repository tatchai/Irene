using Irene.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irene.Data {

  public class RoleRepository : RepositoryBase<Role> {

    public RoleRepository() { }

    public RoleRepository(DbContext context) : base(context) {
      //
    }

  }
}
