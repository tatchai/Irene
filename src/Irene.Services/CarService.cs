using Irene.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irene.Data;

namespace Irene.Services {
  public class CarService : ServiceBase<Car> {
    public CarService(UnitOfWork uow) : base(uow) {
      //
    }

    public override Car Find(params object[] keys) {
      int id = (int)keys[0];
      return Query(c => c.Id == id).SingleOrDefault();
    }

    public override Car Add(Car item) {
      if (item.Color.Length > 4)
        throw new Exception("Too long color name");

      return base.Add(item);
    }
  }
}
