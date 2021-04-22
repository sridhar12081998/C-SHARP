using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter what u want to: \n 1.Addition \n 2.Subtraction \n 3.Multiplication");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
        case 1:
        Console.WriteLine("ADD");
        break;
         case 2:
        Console.WriteLine("SUB");
        break;
         case 3:
        Console.WriteLine("MUL");
        break;
         default:
        Console.WriteLine("NOTHING");
        break;
    }
    Console.ReadLine();
}
}