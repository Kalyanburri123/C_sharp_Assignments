using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism
{
    internal class Manager:Employee
    {
        public Manager(int id, string name, double basic)
        : base(id, name, basic) { }

        public override double CalculateSalary()
        {
            double ta = 0.5 * BasicSalary;
            double da = 0.4 * BasicSalary;
            return BasicSalary + ta + da;
        }
    }
}
