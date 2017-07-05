using Irene.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xunit;

namespace Irene.Services.Facts {
  public class UserServiceFact {

    public class Add {

      [Fact]
      public void BasicUsage() {
        // arrange
        var db = new FakeRepository<User>();
        var s = new UserService(db);
        var u1 = new User();

        // act
        User u = s.Add(u1);
        s.SaveChanges();

        // assert
        Assert.NotNull(u);
        Assert.Equal("USER", u.UserName);
        Assert.Equal(UserStatus.Suspended, u.Status);
        Assert.Equal("Suspended", u.StatusText);

      }

      [Fact]
      public void PINIsGeneratedAfterSaveChanges() {
        const string PIN_1 = "123456";
        var db = new FakeRepository<User>();
        var s = new UserService(db);
        var u1 = new User("Jimmy");
        u1.PIN = PIN_1;

        User user = s.Add(u1);
        Assert.Equal(PIN_1, user.PIN);

        s.SaveChanges();
        Assert.NotEqual(PIN_1, user.PIN);
        Assert.True(Regex.IsMatch(user.PIN, "\\d{6}"));
      }

      [Fact(Skip = "")]
      public void PINIsNotDuplicated() { }
      [Fact(Skip = "")]
      public void UserNameIsNotDuplicated() { }
      [Fact(Skip = "")]
      public void PasswordComplyWithPolicy() { }

    }
  }
}
