using System.IO;
using System;

class Program
{
    static void Main()
    {
        int age;
        Console.WriteLine("Enter the age:");
        Age = Convert.ToInt32(Console.ReadLine());
        
    if (age>18)
    {
    Console.WriteLine("Eligible for Vote");
    }else
    {
    Console.WriteLine("Not Eligible for Vote");
    }
	Console.ReadLine();
}
}