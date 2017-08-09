using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irene.Models {
  public class EntityBase<T> where T : IComparable<T> {

    public T Id { get; set; }

    public string Comment { get; set; }
  }
}
