using System;
using System.Collections.Generic;
namespace StudentGradeSystem
{
    public class Student
    {
        public int studentID;
        public string studentFirstName;
        public string studentLastName;
        public string dob;

        public string studentGender;
        public string studentNationality;
        public string studentAddress;
        public string studentPhoneNumber;

        public string universityCourse;
            public GradeProfile studentsGradeProfile = new GradeProfile();

    public Student(int studentID, string studentFirstName, string studentLastName, string dob, string studentGender, string studentNationality, string studentAddress, string studentPhoneNumber, string universityCourse)
        {
            this.studentID = studentID;
            this.studentFirstName = studentFirstName;
            this.studentLastName = studentLastName;
            this.dob = dob;
            this.studentGender = studentGender;
            this.studentNationality = studentNationality;
            this.studentAddress = studentAddress;
            this.studentPhoneNumber = studentPhoneNumber;
            this.universityCourse = universityCourse;


        }

         public void InformationOnScreen()
        {
            Console.WriteLine($"\nStudents ID: {studentID}\n Students First Name: {studentFirstName} \n Students Last Name: {studentLastName} \n Students Date of Birth: {dob}\n Students Gender: {studentGender}\n Nationality of the Student: {studentNationality}\n Address of the Student: {studentAddress}\n Students Phone Number: {studentPhoneNumber}\n Course that the student is on: {universityCourse}\n");
            studentsGradeProfile.StudentsAverageGrades();
            studentsGradeProfile.StudentsReport();
        }

  
  
}
}

