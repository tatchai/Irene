using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Extensibility;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Irene.Models {
  //[Log(AttributeTargetMemberAttributes = MulticastAttributes.Public)]
  public class User : EntityBase<Guid> {

    public User() : this("USER") {
    }

    public User(string userName) {
      UserName = userName;
      Status = UserStatus.Suspended;
      Cars = new List<Car>();
      Groups = new ObservableListSource<UserGroup>();
    } 
     
    private string _userName;

    [Required]
    [StringLength(30)]
    public string UserName
    {
      get { return _userName; }
      set { _userName = value; NotifyPropertyChanged(); }
    }
    
    public string PasswordHash { get; set; }

    [StringLength(6, MinimumLength = 6)]
    public string PIN { get; set; }

    #region Enum To String
    private UserStatus _Status;
    private string _StatusText;


    [NotMapped]
    public UserStatus Status
    {
      get { return _Status; }
      private set
      {
        _Status = value;
        StatusText = _Status.ToString();
        NotifyPropertyChanged();
      }
    }

    public string StatusText
    {
      get
      {
        return _StatusText;
      }
      set
      {
        _StatusText = value;
        _Status = (UserStatus)Enum.Parse(typeof(UserStatus), value);
        NotifyPropertyChanged();
      }
    }
    #endregion

    public DateTime CreatedDate { get; set; }
    public string CreatedByUserName { get; set; }
    public DateTime? LastVisibleDate { get; set; }

    public string Email { get; set; }
    public string Mobile { get; set; }
    public string Note { get; set; }

    public virtual ObservableListSource<UserGroup> Groups { get; set; }
    public virtual ICollection<Car> Cars { get; set; }
     
    // Methods 
    public bool CanActivate => Status == UserStatus.Suspended;
    public bool CanSuspend => Status == UserStatus.Active;
    public bool CanDisable => Status != UserStatus.Disabled;

    public void Active() {
      if (!CanActivate) throw new Exception();
      Status = UserStatus.Active;
    }

    public void Suspend() {
      if (!CanSuspend) throw new Exception();
      Status = UserStatus.Suspended;
    }

    public void Disable() {
      if (!CanDisable) throw new Exception();
      Status = UserStatus.Disabled;
    }

    public override string ToString() {
      return $"{UserName} ({Status})";
    }

    public string FriendlyName => ToString();
  }
}
