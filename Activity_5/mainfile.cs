using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activity5BL;

namespace Activity_5
{
    public class mainfile
    {
        static void Main(string[] args)
        {

            string specialization;
            try
            {

                Console.WriteLine("Enter the specialization:");
                specialization = Console.ReadLine();
                if (specialization == null)
                    throw new ArgumentException();
                if (specialization != null)
                {
                    foreach (char lt in specialization)
                    {
                        if ((lt >= 'a' && lt <= 'z') || (lt >= 'A' && lt <= 'Z'))
                            continue;
                        else
                            throw new ArgumentException();
                    }
                }
                Employee obj = new SystemsEngineer(specialization);
                Finance fobj = new Finance();
                Employee mobj = new Manager();
                Employee smobj = new SeniorProjectManager();

                Console.WriteLine(fobj.GetCalculatedSalary(obj));
                Console.WriteLine(fobj.GetCalculatedSalary(mobj));
                Console.WriteLine(fobj.GetCalculatedSalary(smobj));

            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid");
            }
            finally
            {
                Console.ReadLine();
                System.Environment.Exit(1000);
            }
        }

    }
}
