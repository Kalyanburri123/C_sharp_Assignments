using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism
{
    internal class Developer:Employee
    {
        public Developer(int id, string name, double basic)
       : base(id, name, basic) { }

        public override double CalculateSalary()
        {
            double pa = 0.4 * BasicSalary;
            return BasicSalary + pa;
        }
    }
}
