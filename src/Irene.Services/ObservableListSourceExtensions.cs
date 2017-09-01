using Irene.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irene.Services {
  public static class ObservableListSourceExtensions {

    //////public static DisconnectedList<T> GetDisconnectedList<T>(
    //////      this ObservableListSource<T> source,
    //////      Func<T, bool> condition) where T : class {
    //////  var result = new DisconnectedList<T>() {
    //////    Condition = condition,
    //////    List = Query(condition).ToList()
    //////  };
    //////  return result;
    //////}

    /// <summary>
    /// 
    /// </summary>
    /// <param name="disconnectedList"></param>
    //////public void MergeWithDisconnectedList(DisconnectedList<T> disconnectedList) {
    //////  var origin = Query(disconnectedList.Condition).ToList();

    //////  foreach (var item in disconnectedList.List.Except(origin)) {
    //////    origin.Add(item);
    //////    Add(item);
    //////  }

    //////  // deleted item
    //////  foreach (var item in origin.Except(disconnectedList.List)) {
    //////    Remove(item);
    //////  }
    //////}
  }
}
