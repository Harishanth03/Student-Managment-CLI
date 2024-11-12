using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_management_system
{
    internal class UndergraduateStudent:Student
    {

        public string Major {  get; set; }

        public int Year { get; set; }

        public UndergraduateStudent(string name, int age, string studentId , string major , int year) : base(name , age , studentId)
        {
            this.Major = major;

            this.Year = year;
        }

        public new void DisplayDetails()
        {
            Console.WriteLine($"UnderGraduate Student: name : {Name} Age : {Age} StudentId : {StudentId}");

            Console.WriteLine($"Major: {Major}, Year: {Year}");
        }
    }
}
