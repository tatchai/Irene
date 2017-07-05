using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irene.Models {
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
    public string UserName { get; set; }

    public string PasswordHash { get; set; }

    [StringLength(6, MinimumLength = 6)]
    public string PIN { get; set; }

    private UserStatus _Status;

    [NotMapped]
    public UserStatus Status {
      get { return _Status; }
      private set {
        _Status = value;
        StatusText = _Status.ToString();
      }
    }

    public string StatusText { get; private set; }

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
