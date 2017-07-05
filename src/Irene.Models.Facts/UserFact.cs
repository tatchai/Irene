using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Irene.Models.Facts {
  public class UserFact {

    public class StatusLifeCycle {

      [Fact]
      public void NewUser_IsSuspended() {
        var u = new User();

        Assert.Equal(UserStatus.Suspended, u.Status);
      }

      [Fact]
      public void FromSuspended() {
        var u1 = new User();
        u1.Active();
        Assert.Equal(UserStatus.Active, u1.Status);

        var u2 = new User();
        u2.Disable();
        Assert.Equal(UserStatus.Disabled, u2.Status);
      }

      [Fact]
      public void FromActive() {
        var u1 = new User();
        u1.Active();
        u1.Disable();
        Assert.Equal(UserStatus.Disabled, u1.Status);

        var u2 = new User();
        u2.Active();
        u2.Suspend();
        Assert.Equal(UserStatus.Suspended, u2.Status);
      }

      [Fact]
      public void FromDisabled_CannotChangeAnymore() {
        var u1 = new User(); 
        u1.Disable();
        Assert.ThrowsAny<Exception>(() => {
          u1.Active();
        });

        var u2 = new User();
        u2.Disable();
        Assert.ThrowsAny<Exception>(() => {
          u2.Suspend();
        });
      }
    }
  }
}
