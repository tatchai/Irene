using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irene.Models {
  public class MapItem<T> {

    public T Id { get; set; } 
    public string Name { get; set; }

  }

  public class MapItemInt : MapItem<int> {
    //
  }

}
