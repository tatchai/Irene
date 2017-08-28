using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Irene.Models {
  public class UserGroup
      : EntityBase<int>,
      IDataErrorInfo, IValidatableObject, INotifyPropertyChanged {

    public UserGroup() {
      Roles = new ObservableListSource<Role>();
      Users = new ObservableListSource<User>();
    }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    public virtual ObservableListSource<Role> Roles { get; set; }
    public virtual ObservableListSource<User> Users { get; set; }

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

    public event PropertyChangedEventHandler PropertyChanged;

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) {
      return Enumerable.Empty<ValidationResult>();
    }
    #endregion

  }
}