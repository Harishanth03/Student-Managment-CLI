using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_management_system
{
    internal class GraduateStudent : Student
    {

        public string ThesisTitle { get; set; }

        public string AdvisorName { get; set; }


        public GraduateStudent(string name, int age, string studentID, string thesisTitle, string advisorName):base(name , age , studentID)
        {
            this.ThesisTitle = thesisTitle;

            this.AdvisorName = advisorName;
        }

        public new void DisplayDetails()
        {
            Console.WriteLine($"UnderGraduate Student: name : {Name} Age : {Age} StudentId : {StudentId}");

            Console.WriteLine($"Thesis Title: {ThesisTitle}, Advisor: {AdvisorName}");
        }
    }
}
