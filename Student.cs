using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traking_Student_Grades_in_Maths
{
    public class Student
    {
        private string StudentName { get; set; }
        private char Grade { get; set; }
        private int Group { get; set; }    

        public Student(string _studentname, char _grade, int _group)
        {
            StudentName = _studentname;
            Grade = _grade; 
            Group = _group; 
        }

        public void GetStudentName()
        {
            Console.WriteLine($"Student Name is {StudentName}");
        }

        public void GetStudentGrade()
        {
            Console.WriteLine($"Student Grade is {Grade}");
        }
       
        public void GetGroupValue()
        {
            Console.WriteLine($"Student Group Value is {Group}");
        }
        public void UpgradeStudentGrade(char Grade)
        {
            if (Grade == 'B' )
            {
                Grade = 'A'; 
            }

            Console.WriteLine($"The Student Grade has Upgraded to {Grade}");
        }
        public void DownGrade(char Grade)
        {
            if (Grade == 'C')
            {
                Grade = 'D';
            }
            if (Grade == 'D')
            {
                Grade = 'F';
            }

            Console.WriteLine($"The Student Grade has downgraded to {Grade}");
        }
    }

    

}