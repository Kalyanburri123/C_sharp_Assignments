using System;
namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Course Type:");
            Console.WriteLine("1. Online Course");
            Console.WriteLine("2. In-Person Course");
            Console.WriteLine("3. Lab Course");

            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Course Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Instructor Name: ");
            string instructor = Console.ReadLine();

            Course course = null;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Video Platform Link: ");
                    string link = Console.ReadLine();
                    course = new OnlineCourse(name, instructor, link);
                    break;

                case 2:
                    Console.Write("Enter Room Number: ");
                    string room = Console.ReadLine();

                    Console.Write("Enter Capacity: ");
                    int cap = Convert.ToInt32(Console.ReadLine());

                    course = new InPersonCourse(name, instructor, room, cap);
                    break;

                case 3:
                    Console.Write("Safety Training Completed (true/false): ");
                    bool training = Convert.ToBoolean(Console.ReadLine());

                    course = new LabCourse(name, instructor, training);
                    break;
            }

            course.EnrollStudent();
        }
    }
}