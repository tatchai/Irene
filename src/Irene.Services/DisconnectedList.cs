using System;
using System.Collections;
using System.Collections.Generic;

namespace Irene.Services {
  public class DisconnectedList<T> where T : class {

    public Func<T, bool> Condition { get; set; }
    public List<T> List { get; set; }

  }
}