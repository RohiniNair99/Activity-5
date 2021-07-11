using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity5BL
{
    public class Manager : Employee
    {
        public double PhoneAllowance { get; set; }
        public Manager()
        {
            PhoneAllowance = 1400;
        }
        public override double CalculateSalary()
        {
            base.CalculateSalary();
            return (BasicSalary + PhoneAllowance);
        }
    }
}
