using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPoc
{
    public class Student
    {
        public int Id;
        public string Name;
        public double Marks;

        public override string ToString()
        {
            return $"Id: {Id},Name: {Name},Marks: { Marks}";
        }
    }
}
