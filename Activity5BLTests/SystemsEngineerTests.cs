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
    public class SystemsEngineerTests
    {
        [TestMethod()]
        public void NCalculateSalaryTest()
        {
            SystemsEngineer obj = new SystemsEngineer();
            obj.Specialization = "Ruby";
            double expected = 13000D;
            double actual = obj.CalculateSalary();
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod()]
        public void PCalculateSalaryTest()
        {
            SystemsEngineer obj = new SystemsEngineer();
            obj.Specialization = "Java";
            double expected = 13000D;
            double actual= obj.CalculateSalary();
            Assert.AreEqual(expected, actual);

        }
    }
}