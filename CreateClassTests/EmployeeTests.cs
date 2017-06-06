using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreateClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass.Tests
{
    [TestClass()]
    public class EmployeeTests
    {
        [TestMethod()]
        public void EmployeeNameTest()
        {
            Room room1 = new Room(1);
            Employee ceo = new Employee("john", DateTime.Now,1000,"CEO", room1);
            Assert.AreEqual("john",ceo.name);
        }

        [TestMethod()]
        public void EmployeeSalaryTest()
        {
            Room room1 = new Room(1);
            Employee ceo = new Employee("john", DateTime.Now, 1000, "CEO", room1);
            Assert.AreEqual(1000, ceo.salary);
        }

        [TestMethod()]
        public void EmployeePositionTest()
        {
            Room room1 = new Room(1);
            Employee ceo = new Employee("john", DateTime.Now, 1000, "CEO", room1);
            Assert.AreEqual("CEO", ceo.position);
        }

    }
}