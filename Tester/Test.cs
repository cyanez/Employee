using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EmployeeFrameWork;
using Xunit;

namespace Tester {
  public class Test {
    
      [Fact]
      public void TestSayHello() {
        Employee employee = new Employee();

        employee.Name = "Christian";
        var returnValue = employee.SayHello();

        Assert.Equal("hello Christian", returnValue);
      }
    }

  
}
