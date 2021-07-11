using Microsoft.VisualStudio.TestTools.UnitTesting;
using Activity5BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity5BL.Tests
{
    [TestClass()]
    public class ManagerTests
    {
        [TestMethod()]
        public void PCalculateSalaryTest()
        {
            Manager obj = new Manager();
            double expected = 11400;
            double actual = obj.CalculateSalary();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NCalculateSalaryTest()
        {
            Manager obj = new Manager();
            double expected = 1400;
            double actual = obj.CalculateSalary();
            Assert.AreNotEqual(expected, actual);
        }
    }
}