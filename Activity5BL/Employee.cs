using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity5BL
{
    public class Employee
    {
        private double basicSalary;
        private double bonus;
        private int employeeId;

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        public double BasicSalary
        {
            get { return basicSalary; }
            set { basicSalary = value; }
        }
        public double Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }

        public Employee()
        {
            basicSalary = 10000;
        }
        public virtual double CalculateSalary()
        {
            return basicSalary;
        }
    }
}
