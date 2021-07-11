using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity5BL
{
    public class SystemsEngineer : Employee
    {
        public string specialization;
        public double SpecialistAllowance { get; set; }
        public string Specialization { get { return specialization; } set { specialization = value; } }

        public SystemsEngineer()
        {
            specialization = "";
        }
        
        
        public SystemsEngineer(string specialization) : base()
        {
            this.specialization = specialization;
        }

        public override double CalculateSalary()
        {
            double salary=base.CalculateSalary();
            if ((specialization.Equals("SQL", StringComparison.OrdinalIgnoreCase)) || (specialization.Equals("C#", StringComparison.OrdinalIgnoreCase)) || (specialization.Equals("Java", StringComparison.OrdinalIgnoreCase)))
            {
                SpecialistAllowance = 3000;
            }
            else
                SpecialistAllowance = 0.0;
            return (salary + SpecialistAllowance);
        }
    }
}
