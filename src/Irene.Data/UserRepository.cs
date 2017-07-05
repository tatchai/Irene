using Irene.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Irene.Data {
  public class UserRepository : RepositoryBase<User> {
    public UserRepository(DbContext context) : base(context) {
    }
  }
}
