using System;
namespace PredicateDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Creating list of students
            List<Student> students = new List<Student>()
            {
                new Student { Name = "Amit", Marks = 75, Age = 20 },
                new Student { Name = "Anita", Marks = 82, Age = 19 },
                new Student { Name = "Arjun", Marks = 65, Age = 17 },
                new Student { Name = "Ravi", Marks = 55, Age = 16 },
                new Student { Name = "Kiran", Marks = 45, Age = 21 },
                new Student { Name = "Sita", Marks = 30, Age = 18 }
            };

            // Predicate for Marks > 60
            Predicate<Student> highMarks = s => s.Marks > 60;

            // Predicate for Age < 18
            Predicate<Student> minorStudents = s => s.Age < 18;

            // Predicate for Name starts with 'A'
            Predicate<Student> nameStartsWithA = s => s.Name.StartsWith("A");

            //Using FindAll to find.
            var studentsWithHighMarks = students.FindAll(highMarks);
            var studentsMinor = students.FindAll(minorStudents);
            var studentsNameA = students.FindAll(nameStartsWithA);

            Console.WriteLine("Students with Marks > 60:");
            foreach (var s in studentsWithHighMarks)
            {
                Console.WriteLine(s.Name);
            }

            Console.WriteLine("\nStudents Age < 18:");
            foreach (var s in studentsMinor)
            {
                Console.WriteLine(s.Name);
            }

            Console.WriteLine("\nNames starting with A:");
            foreach (var s in studentsNameA)
            {
                Console.WriteLine(s.Name);
            }

            // Using Exists() to check wheather topper is present or not.
            bool anyTopper = students.Exists(highMarks);
            Console.WriteLine("Any student with Marks > 60: " + anyTopper);
        }
    }
}