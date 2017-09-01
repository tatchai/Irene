using Irene.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irene.Data;

namespace Irene.Services {
  public class CarService : ServiceBase<Car, int> {
    public CarService(UnitOfWork uow) : base(uow) {
      //
    }
     

    public override Car Add(Car item) {
      if (item.Color.Length > 4)
        throw new Exception("Too long color name");

      return base.Add(item);
    }
  }
}
