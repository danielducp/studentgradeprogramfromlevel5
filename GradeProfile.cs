using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGradeSystem
{
    public class GradeProfile
    {
       List<Grade> studentsGradeProfile = new List<Grade>();

        public void AddAGrade(Grade gradeofthestudent)
        {
            studentsGradeProfile.Add(gradeofthestudent);
        }

        public void DisplayStudentsGrades()
        {
            foreach (Grade gradeofthestudent in studentsGradeProfile)
            {
                Console.WriteLine(gradeofthestudent.studentGrade);
            }
        }
        public int StudentsAverageGrades()
        {

            List<int> studentsaveragegrade = new List<int>(); 

            foreach (Grade gradeofthestudent in studentsGradeProfile)
            {
                studentsaveragegrade.Add(gradeofthestudent.studentGrade); 
            }

            int studentsaveragegrades = Convert.ToInt32(studentsaveragegrade.Average());

            return studentsaveragegrades;
        }

        public void StudentsReport()
        {
            foreach (Grade gradeofthestudent in studentsGradeProfile)
            {
                Console.WriteLine($"Assigntment Name: {gradeofthestudent.assignmentName}");
                Console.WriteLine($"Assignment Number: {gradeofthestudent.assignmentNumber}");
                Console.WriteLine($"Grade of the student: {gradeofthestudent.studentGrade}");
       
              
            }
    }}
}