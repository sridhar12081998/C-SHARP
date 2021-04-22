using System.IO;
using System;

class student
{
   public int rollnumber {get; set;}
   public string name {get; set;}
   public string gender {get; set;}
   static void main()
   {
    Student student = new Student();
    student.rollnumber = 1; 
    student.name = "sridhar"; 
    student.gender = "Male"; 
    Console.WriteLine(student.rollnumber +"\t" student.name  +"\t" student.gender);
    Console.ReadLine();
   }
}