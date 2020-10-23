using Xunit;

using EmployeeFrameWork;

namespace Test {
  class EmployeeTest {
    public class UnitTest {
      [Fact]
      public void TestSayHello() {
        Employee employee = new Employee();

        employee.Name = "Christian";
        var returnValue = employee.SayHello();

        Assert.Equal("hello Christian", returnValue);
      }

    }

    }
}
