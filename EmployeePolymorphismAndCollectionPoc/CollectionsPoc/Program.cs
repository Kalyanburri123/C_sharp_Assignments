using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsPoc
{
    class Program
    {
        public static void Main(string[] args)
        {
            ListCrudOperations();
            SetCrudOperations();
            DictionaryCrudOperations();
        }

        public static void ListCrudOperations()
        {
            List<Student> students = new List<Student>();

            // CREATE
            students.Add(new Student { Id = 1, Name = "Kalyan", Marks = 45 });
            students.Add(new Student { Id = 2, Name = "Vikram", Marks = 39 });
            students.Add(new Student { Id = 3, Name = "Akshith", Marks = 95 });

            // READ
            Console.WriteLine("Student List:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            // UPDATE
            Console.WriteLine("\nEnter the Id to update:");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id) || !students.Any(s => s.Id == id))
            {
                Console.WriteLine("Invalid Id. Enter existing Id:");
            }

            var studentToUpdate = students.First(s => s.Id == id);

            Console.WriteLine("Enter new Name:");
            string updatedName;

            while (string.IsNullOrWhiteSpace(updatedName = Console.ReadLine()) ||
                   !updatedName.All(c => char.IsLetter(c) || c == ' '))
            {
                Console.WriteLine("Invalid name. Enter alphabets only:");
            }

            if (studentToUpdate.Name != updatedName)
            {
                Console.WriteLine($"Updated name from {studentToUpdate.Name} to {updatedName}");
                studentToUpdate.Name = updatedName;
            }
            else
            {
                Console.WriteLine("Same name entered. No changes made.");
            }

            // DELETE
            Console.WriteLine("\nEnter the Id to delete:");
            int deleteId;

            while (!int.TryParse(Console.ReadLine(), out deleteId) || !students.Any(s => s.Id == deleteId))
            {
                Console.WriteLine("Invalid Id. Enter existing Id:");
            }

            var studentToDelete = students.First(s => s.Id == deleteId);
            students.Remove(studentToDelete);

            Console.WriteLine($"Student with Id {deleteId} deleted.");

            // FINAL LIST
            Console.WriteLine("\nFinal Student List:");
            foreach (var s in students)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("===========================");
        }
        public static void SetCrudOperations()
        {
            HashSet<Student> students = new HashSet<Student>();

            // CREATING THE SET DATA.
            students.Add(new Student { Id = 1, Name = "Kalyan Reddy", Marks = 55 });
            students.Add(new Student { Id = 2, Name = "Vikram Rathod", Marks = 69 });
            students.Add(new Student { Id = 3, Name = "Akshith Kumar", Marks = 75 });

            // READING THE SET DATA.
            Console.WriteLine("Set Data:");
            foreach (var s in students)
            {
                Console.WriteLine(s);
            }

            // UPDATING THE SET DATA.
            Console.WriteLine("Enter Id to update:");
            int id;

            while (!int.TryParse(Console.ReadLine(), out id) || !students.Any(s => s.Id == id))
            {
                Console.WriteLine("Invalid Id. Try again:");
            }

            var studentToUpdate = students.First(s => s.Id == id);

            Console.WriteLine("Enter new name:");
            string newName;

            while (string.IsNullOrWhiteSpace(newName = Console.ReadLine()) ||
                   !newName.All(c => char.IsLetter(c) || c == ' '))
            {
                Console.WriteLine("Invalid name:");
            }

            students.Remove(studentToUpdate);
            studentToUpdate.Name = newName;
            students.Add(studentToUpdate);

            // DELETING THE SET DATA.
            Console.WriteLine("\nEnter Id to delete:");
            int deleteId;

            while (!int.TryParse(Console.ReadLine(), out deleteId) || !students.Any(s => s.Id == deleteId))
            {
                Console.WriteLine("Invalid Id:");
            }

            var studentToDelete = students.First(s => s.Id == deleteId);
            students.Remove(studentToDelete);

            // FINAL OUTPUT
            Console.WriteLine("\nAfter Delete:");
            foreach (var s in students)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("===========================");
        }
        public static void DictionaryCrudOperations()
        {
            Dictionary<int, Student> students = new Dictionary<int, Student>();

            // CREATING THE DICTIONARY.
            students.Add(1, new Student { Id = 1, Name = "Kalyan", Marks = 45 });
            students.Add(2, new Student { Id = 2, Name = "Vikram", Marks = 39 });
            students.Add(3, new Student { Id = 3, Name = "Akshith", Marks = 95 });

            // READING THE DICTIONARY
            Console.WriteLine("\nDictionary Data:");
            foreach (var item in students)
            {
                Console.WriteLine(item.Value);
            }

            // UPDATING THE DICTIONARY VALUES.
            Console.WriteLine("\nEnter Id to update:");
            int id;

            while (!int.TryParse(Console.ReadLine(), out id) || !students.ContainsKey(id))
            {
                Console.WriteLine("Invalid Id:");
            }

            Console.WriteLine("Enter new name:");
            string newName;

            while (string.IsNullOrWhiteSpace(newName = Console.ReadLine()) ||
                   !newName.All(c => char.IsLetter(c) || c == ' '))
            {
                Console.WriteLine("Invalid name:");
            }

            students[id].Name = newName;

            // DELETING THE DICTIONAY DATA.
            Console.WriteLine("\nEnter Id to delete:");
            int deleteId;

            while (!int.TryParse(Console.ReadLine(), out deleteId) || !students.ContainsKey(deleteId))
            {
                Console.WriteLine("Invalid Id:");
            }

            students.Remove(deleteId);

            Console.WriteLine("\nAfter Delete:");
            foreach (var item in students)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}