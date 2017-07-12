using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Extensibility;

namespace Irene.Models {
  //[Log(AttributeTargetMemberAttributes = MulticastAttributes.Public)]
  public class User {

    public User() : this("USER") {
    }

    public User(string userName) {
      UserName = userName;
      Status = UserStatus.Suspended;
    }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    [Required]
    [StringLength(30)]
    public string UserName { get; set; }

    public string PasswordHash { get; set; }

    [StringLength(6, MinimumLength = 6)]
    public string PIN { get; set; }

    #region Enum To String
    private UserStatus _Status;
    private string _StatusText;

    [NotMapped]
    public UserStatus Status {
      get { return _Status; }
      private set {
        _Status = value;
        StatusText = _Status.ToString();
      }
    }

    public string StatusText {
      get {
        return _StatusText;
      }
      set {
        _StatusText = value;
        _Status = (UserStatus)Enum.Parse(typeof(UserStatus), value);
      }
    }
    #endregion

    public DateTime CreatedDate { get; set; }
    public string CreatedByUserName { get; set; }
    public DateTime? LastVisibleDate { get; set; }

    public string Email { get; set; }
    public string Mobile { get; set; }
    public string Note { get; set; }


    // Methods 
    public void Active() {
      if (Status == UserStatus.Disabled) {
        throw new Exception();
      }
      Status = UserStatus.Active;
    }

    public void Suspend() {
      if (Status == UserStatus.Disabled) {
        throw new Exception();
      }
      Status = UserStatus.Suspended;
    }

    public void Disable() {
      Status = UserStatus.Disabled;
    }
  }
}
