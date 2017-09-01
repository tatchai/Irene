using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irene.Models {
  public class Role : EntityBase<int>, IEqualityComparer<Role> {

    public Role() {
      Groups = new ObservableListSource<UserGroup>();
    }
    public string Name { get; set; }

    public virtual ObservableListSource<UserGroup> Groups { get; set; }

    public bool Equals(Role x, Role y) {
      if (x == null || y == null) return false;
      return x.Id == y.Id;
    }

    public int GetHashCode(Role obj) {
      return (obj as Role).Id.GetHashCode();
    }
  }
}
