using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeFrameWork {
  public class Employee {
    private string name;
    public string Name {
      get => name;
      set => name = value;
    }

    private string age;
    public string Age {
      get => age;
      set => age = value;
    }
    public string SayHello() {
      return $"hello {name}";
    }
  }
}
