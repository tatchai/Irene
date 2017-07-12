using Irene.Data;
using Irene.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Irene.Services {
  // SUT
  public class UserService : ServiceBase<User> {

    public UserService(UnitOfWork uow) : base(uow) {
    }

    public override User Add(User item) {
      return base.Add(item);
    }

    public override User Find(params object[] keys) {
      var id = (Guid)keys[0];
      return Query(item => item.Id == id).SingleOrDefault();
    }

    public override void OnSaveChanges() {
      foreach (var user in All(fromLocal: true)) {
        if (IsNewUser(user)) {

          // Check existing UserName
          if (All().Any(x => x.Id != user.Id && x.UserName == user.UserName)) {
            throw new Exception();
          }

          // Create PIN  
          // Must assign PIN manually before save to database.
          // Call GenerateUniquePIN method.
          // user.PIN = GenerateUniquePIN();
           
          ValidatePIN(user);

          // Mark records
          user.CreatedDate = DateTime.Now;
          user.CreatedByUserName = string.Empty;
          user.LastVisibleDate = null;
        }
      } 
    }

    private void ValidatePIN(User user) {
      if (!Regex.IsMatch(user.PIN, "\\d{6}"))
        throw new Exception("PIN is invalid");
      if (PinExists(user.PIN))
        throw new Exception("PIN is duplicated");
    }

    private static bool IsNewUser(User item) {
      return item.Id == Guid.Empty;
    }

    public string GenerateUniquePIN() {
      string pin;
      do {
        pin = GeneratePIN();
      } while (PinExists(pin));
      return pin;
    }

    private bool PinExists(string pin) {
      return All().Any(x => x.PIN == pin);
    }

    private string GeneratePIN() {
      return DateTime.Now.ToString("mmssff");
    }
  }
}
