using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Data.Entity;
using System;

namespace Irene.Models {
  public class ObservableListSource<T> : ObservableCollection<T>, IListSource
      where T : class {
    private IBindingList _bindingList;

    bool IListSource.ContainsListCollection { get { return false; } }

    IList IListSource.GetList() {
      return _bindingList ?? (_bindingList = this.ToBindingList());
    }

    // MergeWithDisconnectedList
    // GetDisconnectedList
    //public DisconnectedList<T> GetDisconnectedList(Func<T, bool> condition) {
    //  var result = new DisconnectedList<T>() {
    //    Condition = condition,
    //    List = Query(condition).ToList()
    //  };
    //  return result;
    //}

  }
}
