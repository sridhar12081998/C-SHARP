using System.IO;
using System;

class Program
{
    static void Main()
    {
        int Age;
        Console.Write("Enter the age: \n");
        Age = Convert.ToInt32(Console.ReadLine());
        
    if (Age<18)
    {
    Console.WriteLine("You are Not Eligible to vote");
    }
    else if (Age>=60)
    {
    Console.WriteLine("You are Senior Citizen");
    }
    else
    {
    Console.WriteLine("You are Eligible to vote");
    }
    Console.ReadLine();
}
}