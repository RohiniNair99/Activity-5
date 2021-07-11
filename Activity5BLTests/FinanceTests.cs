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
    public class FinanceTests
    {
        [TestMethod()]
        public void PGetCalculatedSalaryTest()
        {
            Employee obj = new SystemsEngineer("Java");
            Finance fobj = new Finance();
            double expected = 18000;
            double actual = fobj.GetCalculatedSalary(obj);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NGetCalculatedSalaryTest()
        {
            Employee obj = new SystemsEngineer("HAHA");
            Finance fobj = new Finance();
            double expected = 18000;
            double actual = fobj.GetCalculatedSalary(obj);
            Assert.AreNotEqual(expected, actual);
        }
    }
}