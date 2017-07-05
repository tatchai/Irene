using Irene.Data;
using Irene.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irene.Services {
  // SUT
  public class UserService : ServiceBase<User> {

    public UserService(IRepository<User> baseRepo) : base(baseRepo) {
    }

    public override User Add(User item) {
      return base.Add(item);
    }

    public override User Find(params object[] keys) {
      var id = (Guid)keys[0];
      return Query(item => item.Id == id).SingleOrDefault();
    }

    public override int SaveChanges() {
      foreach (var item in All(fromLocal: true)) {
        if (item.Id == Guid.Empty) {
          if (All().Any(x => x.Id != item.Id && x.UserName == item.UserName)) {
            throw new Exception();
          }

          string pin;
          do {
            pin = GeneratePIN();
          } while (All().Any(x => x.PIN == pin));
          item.PIN = pin;
        }
      }
      return base.SaveChanges();
    }

    private string GeneratePIN() {
      return DateTime.Now.ToString("mmssff");
    }
  }
}
