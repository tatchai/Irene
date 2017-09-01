using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irene.Services {
  public static class CollectionHelper {


    public static void ApplyTo<U>(this ICollection<U> current, ICollection<U> origin) where U : class {
      // add items
      foreach (var item in current.Except(origin)) {
        origin.Add(item);
      }

      // deleted items
      foreach (var item in origin.Except(current).ToList()) {
        origin.Remove(item);
      }

    }
  }
}
