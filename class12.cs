using System.IO;
using System;
 
 public enum Salutation
 {
     Mr = 0,
     Ms = 1,
     Mrs = 2,
     Dr = 3,
 }
class student
{
   static void main()
   {
    Salutation salutation;
    string name;
    Console.WriteLine("Enter the Salutation");
    salutation = (Salutation)Enum.Parse(typeof(Salutation), Console.ReadLine());
    Console.WriteLine("Enter the Name");
    name = Console.ReadLine();
    Console.Write(" \n your name is:{0}",salutation.ToString());
    Console.Write("." + name);
    Console.ReadLine();
   }
}