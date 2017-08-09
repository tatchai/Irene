using System.Collections.Generic;

namespace Irene.Models {
  public class UserGroup : EntityBase<int> {

    public UserGroup() {
      //
    }
     
    public string Name { get; set; }

    public virtual ICollection<Role> Roles { get; set; } = new HashSet<Role>();
    public virtual ICollection<User> Users { get; set; } = new HashSet<User>();
  }
}