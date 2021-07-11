using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity5BL
{
    public class Finance
    {
        public double GetCalculatedSalary(Employee obj)
        {
            if (obj.GetType() == typeof(SystemsEngineer))
            {
                obj.Bonus = 5000.0D;
            }
            else if (obj.GetType() == typeof(Manager))
            {
                obj.Bonus = 9000.0D;
            }
            else if (obj.GetType() == typeof(SeniorProjectManager))
            {
                obj.Bonus = 15000.0D;
            }
            else
            {
                obj.Bonus = 0.0D;
            }
            
            return (obj.Bonus + obj.CalculateSalary());
        }
    }
}
