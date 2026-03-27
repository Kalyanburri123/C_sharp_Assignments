using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphism
{
    abstract class Employee
    {
        public int Id;
        public string Name;
        public double BasicSalary;
        public Employee(int Id, string Name, double BasicSalary)
        {
            this.Id = Id;
            this.Name = Name;
            this.BasicSalary = BasicSalary;
        }

        // Polymorphic Method
        public abstract double CalculateSalary();

        public virtual void Display()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, BasicSalary: {BasicSalary}");
        }
    }
}
