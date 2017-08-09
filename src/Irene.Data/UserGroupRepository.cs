using Irene.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irene.Data {

  public class UserGroupRepository : RepositoryBase<UserGroup> {

    public UserGroupRepository() { }

    public UserGroupRepository(DbContext context) : base(context) {
      //
    }

  }
}
