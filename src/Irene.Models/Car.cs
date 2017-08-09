using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irene.Models {
  public class Car : EntityBase<int>, IValidatableObject, IDataErrorInfo {

    public string this[string columnName]
    {
      get
      {
        if (columnName == "Color")
        {
          if (Color?.Length > 4)
          {
            return "Color is too long";
          }
          return "";
        }
        return "";
      }
    }

    public string Color { get; set; }

    public string Error
    {
      get
      {
        return ""; // this[nameof(Color)];
      }
    }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) {
      if (this[nameof(Color)] != "")
        yield return new ValidationResult(this[nameof(Color)], new string[] { nameof(Color) });
    }
  }
}
