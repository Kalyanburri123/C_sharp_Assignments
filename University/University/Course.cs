using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    abstract class Course
    {
        protected string CourseName;
        protected string Instructor;

        public Course(string courseName, string instructor)
        {
            CourseName = courseName;
            Instructor = instructor;
        }

        public abstract void EnrollStudent();
    }
    class OnlineCourse : Course
    {
        string VideoPlatformLink;

        public OnlineCourse(string name, string instructor, string link)
            : base(name, instructor)
        {
            VideoPlatformLink = link;
        }

        public override void EnrollStudent()
        {
            if (string.IsNullOrEmpty(VideoPlatformLink))
            {
                Console.WriteLine("Online course must have a video platform link.");
            }
            else
            {
                Console.WriteLine($"Student enrolled in Online Course: {CourseName}");
                Console.WriteLine("Video Link: " + VideoPlatformLink);
            }
        }
    }
    class InPersonCourse : Course
    {
        string RoomNumber;
        int Capacity;

        public InPersonCourse(string name, string instructor, string room, int capacity)
            : base(name, instructor)
        {
            RoomNumber = room;
            Capacity = capacity;
        }

        public override void EnrollStudent()
        {
            if (Capacity <= 0)
            {
                Console.WriteLine("Invalid room capacity.");
            }
            else
            {
                Console.WriteLine($"Student enrolled in In-Person Course: {CourseName}");
                Console.WriteLine($"Room: {RoomNumber} | Capacity: {Capacity}");
            }
        }
    }
    class LabCourse : Course
    {
        bool SafetyTrainingCompleted;

        public LabCourse(string name, string instructor, bool safetyTraining)
            : base(name, instructor)
        {
            SafetyTrainingCompleted = safetyTraining;
        }

        public override void EnrollStudent()
        {
            if (!SafetyTrainingCompleted)
            {
                Console.WriteLine("Safety training must be completed before enrolling.");
            }
            else
            {
                Console.WriteLine($"Student enrolled in Lab Course: {CourseName}");
            }
        }
    }
}