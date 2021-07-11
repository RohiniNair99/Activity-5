using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity5BL
{
    public class SeniorProjectManager : Employee
    {
        public double CarAllowance { get; set; }

        public SeniorProjectManager()
        {
            CarAllowance = 6000;
        }
        public override double CalculateSalary()
        {
            base.CalculateSalary();
            return (BasicSalary + CarAllowance);
        }
    }
}
