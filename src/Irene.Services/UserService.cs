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
      foreach (var user in All(fromLocal: true)) {
        if (IsNewUser(user)) {

          // Check existing UserName
          if (All().Any(x => x.Id != user.Id && x.UserName == user.UserName)) {
            throw new Exception();
          }

          // Create PIN  
          user.PIN = GenerateUniquePIN();

          // Mark records
          user.CreatedDate = DateTime.Now;
          user.CreatedByUserName = string.Empty;
          user.LastVisibleDate = null;
        }
      }
      return base.SaveChanges();
    }

    private static bool IsNewUser(User item) {
      return item.Id == Guid.Empty;
    }

    private string GenerateUniquePIN() {
      string pin;
      do {
        pin = GeneratePIN();
      } while (All().Any(x => x.PIN == pin));
      return pin;
    } 

    private string GeneratePIN() {
      return DateTime.Now.ToString("mmssff");
    }
  }
}
