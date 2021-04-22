using System.IO;
using System;

class Program
{
    static void Main()
    {
        int firstNumber, secondNumber, result;
        Console.Write("\n Enter firstNumber:");
        firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("\n Enter secondNumber:");
        secondNumber = Convert.ToInt32(Console.ReadLine());
        result = firstNumber+secondNumber;
        Console.WriteLine("\n sum is:" +result);
        Console.ReadLine();
    }
}