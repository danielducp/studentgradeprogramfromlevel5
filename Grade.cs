using System;
using System.Collections.Generic;

namespace StudentGradeSystem
{
    public class Grade
    {
        public int studentGrade {get; set;}
        public int assignmentNumber {get; set;}
        public string assignmentName {get;set;}
      public int weight {get;set;}

       public Grade(int studentGrade, int assignmentNumber, string assignmentName, int weight)
        {
            this.studentGrade = studentGrade;
            this.assignmentNumber = assignmentNumber;
            this.assignmentName = assignmentName;
           this.weight = weight;


        }



    }
}