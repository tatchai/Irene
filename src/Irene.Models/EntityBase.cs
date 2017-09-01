using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Irene.Models {
  public class EntityBase<T> : INotifyPropertyChanged
      where T : IComparable<T> {

    public T Id { get; set; }
    public string Comment { get; set; }


    public event PropertyChangedEventHandler PropertyChanged;

    // helpers
    protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "") {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
      MarkAsDirty();
    }

    // ui logics
    [NotMapped]
    public bool IsDirty { get; private set; } = false;
    public void MarkAsDirty() {
      if (!IsDirty) {
        IsDirty = true;
        ContentChanged?.Invoke(this, EventArgs.Empty);
      }
    }
    public void ClearDirty() { if (IsDirty) IsDirty = false; }
    public event EventHandler ContentChanged = null;
  }
}
