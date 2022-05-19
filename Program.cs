using System;
using Traking_Student_Grades_in_Maths;

 string StudentName = "Eman";
 char Grade = 'C';
 int Group = 3;

Student student = new(StudentName, Grade, Group);

student.GetStudentName();
student.GetStudentGrade();
student.GetGroupValue();

if (Grade == 'A' || Grade == 'B')
{
    student.UpgradeStudentGrade(Grade);
}

if (Grade <= 'C')
{
    student.DownGrade(Grade);
}

