using System.IO;
using System;

class Program
{
    static void Main()
    {
        int[,] arr = new int[2,2];
        int row, col;
         Console.WriteLine("Enter the Numbers");
         
         for(row=0; row< arr.GetLength(0); row++)
         {
            for(col=0; col< arr.GetLength(1); col++)
            {
                
                arr[row,col] = Convert.ToInt32(Console.ReadLine());
            }
         }
         Console.WriteLine("-----------------------------");
	Console.WriteLine("Before the Transpose");
         for(row=0; row< arr.GetLength(0); row++)
         {
            for(col=0; col< arr.GetLength(1); col++)
            {
                
                Console.Write(arr[row,col] + "\t");
            }
            Console.WriteLine("\n");
         }
	Console.WriteLine("After the Transpose");
         for(row=0; row< arr.GetLength(0); row++)
         {
            for(col=0; col< arr.GetLength(1); col++)
            {
                
                Console.Write(arr[col,row] + "\t");
            }
            Console.WriteLine("\n");
        Console.ReadLine();
    }

}