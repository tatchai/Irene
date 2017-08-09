using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irene.Models {
  public class Role : EntityBase<int> {
     
    public string Name { get; set; }

    public ICollection<UserGroup> UserGroups { get; set; } = new HashSet<UserGroup>();
 
  }
}
