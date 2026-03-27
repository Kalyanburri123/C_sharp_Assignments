using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism
{
    internal class Tester : Employee
    {
        public Tester(int id, string name, double basic)
            : base(id, name, basic) { }

        public override double CalculateSalary()
        {
            double perks = 0.3 * BasicSalary;
            return BasicSalary + perks;
        }
    }
}
