using System.IO;
using System;

class Program
{
    static void Main()
    {
        int number;
        number = Convert.ToInt32(Console.ReadLine());
        if(number % 2 == 0)
        {
            Console.WriteLine(number + "is divisible by 2");
        }else if(number % 3 == 0)
        {
            Console.WriteLine(number + "is divisible by 3");
        }else if(number % 5 == 0)
        {
            Console.WriteLine(number + "is divisible by 5");
        }else 
        {
        Console.WriteLine(number + "is not divisible by 2, 3, 5");
    }
    Console.ReadLine();
}