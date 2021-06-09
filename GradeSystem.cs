
using System;
using System.Collections.Generic;
namespace StudentGradeSystem
{
    public class GradeSystem
    {
 
             public void Menu()
        {
 
            Console.WriteLine("Option 1: View all report cards and average grades");
            Console.WriteLine("Option 2: Quit");
        
  

            MainMenu();
        }

        public  void MainMenu()
        {
            int usersChoice = 0;

            usersChoice = Convert.ToInt32(Console.ReadLine());

            switch (usersChoice)
            {
                case 1:
                ViewStudents();
                 break;
                case 2:
                Environment.Exit(0);
                    break;
             
                default:
                    break;
            }}
        
        public void ViewStudents(){
                   Student firststudent= new Student (1, "John", "Smith","13/07/99", "Male", "English", "Surfleet, Spaldimg, Lincolnshire, PE114DQ", "01775 645354", "BSc (Hons) Computing and Information Systems"); 
            Student secondstudent= new Student (2, "Joe", "Blogs","02/02/96", "Male", "English", "Kirton, Boston, Lincolnshire, PE201AP", "01205 658345", "BSc (Hons) Computing and Information Systems"); 
            List <Student> students = new List<Student>();
            GradeProfile studentsGradeProfile = new GradeProfile();
            students.Add(firststudent);
            students.Add(secondstudent);


            Grade firstgrade = new Grade(50, 010, "Programming Concepts", 30);
            Grade secondgrade = new Grade(70, 010, "Networking", 70);
            Grade thirdgrade = new Grade(40, 010, "Programming Concepts", 30);
            Grade forthgrade = new Grade(70, 010, "Networking", 70);

            firststudent.studentsGradeProfile.AddAGrade(firstgrade);
            firststudent.studentsGradeProfile.AddAGrade(secondgrade);
            secondstudent.studentsGradeProfile.AddAGrade(thirdgrade);
            secondstudent.studentsGradeProfile.AddAGrade(forthgrade);

    firststudent.InformationOnScreen();
    Console.WriteLine("Student 1 Average Grade : " + firststudent.studentsGradeProfile.StudentsAverageGrades());
    secondstudent.InformationOnScreen();
    Console.WriteLine("Student 2 Average Grade : " + secondstudent.studentsGradeProfile.StudentsAverageGrades());
    }
    }
}