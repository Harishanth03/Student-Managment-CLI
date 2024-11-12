using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_management_system
{
    internal class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string StudentId { get; }

        public Student(string name, int age, string studentId)
        {
            Name = name;

            Age = age > 0 ? age : throw new ArgumentException("Age can't be negative or 0");

            StudentId = studentId;
        }

        public void DisplayBasicInfo()
        {
            Console.WriteLine($"The student name is: {Name}");

            Console.WriteLine($"The student id is: {StudentId}");
        }

        public void DisplayDetails()
        {
            Console.WriteLine("This is Student");
        }
    }


}
