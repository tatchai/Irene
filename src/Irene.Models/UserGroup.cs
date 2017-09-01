using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Irene.Models {
  public class UserGroup : EntityBase<int>, IDataErrorInfo, IValidatableObject {

    public UserGroup() {
      Roles = new ObservableListSource<Role>();
      Users = new ObservableListSource<User>();
    }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    public virtual ObservableListSource<Role> Roles { get; set; }
    public virtual ObservableListSource<User> Users { get; set; }

    public void AddUser(User item) {
      if (Users.Any(u => u.Id == item.Id)) throw new Exception("Cannot add user. Duplicate user.");

      Users.Add(item);
      NotifyPropertyChanged(nameof(Users));
    }

    public void RemoveUser(Guid userId) {
      var user = Users.SingleOrDefault(u => u.Id == userId);
      if (user == null) {
        throw new Exception("User does not exist");
      }

      Users.Remove(user);
      NotifyPropertyChanged(nameof(Users)); 
    }

    #region Interface Implementations
    public string this[string columnName]
    {
      get {
        switch (columnName) {
          case nameof(Name):
            if (string.IsNullOrEmpty(Name)) return "Name is required";
            if (Name.Length > 50) return "Name is too long";
            break;
        }
        return "";
      }
    }
    public string Error => this[nameof(Name)];

    public bool IsValid => string.IsNullOrEmpty(Error); 

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) {
      return Enumerable.Empty<ValidationResult>();
    }
    #endregion

  }
}