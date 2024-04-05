// See https://aka.ms/new-console-template for more information
using System;
namespace ForLoop
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int sum1=0;
            Console.Write("Enter starting point :");
            int start=int.Parse(Console.ReadLine());
            Console.Write("Enter End Limit :");
            int end= int.Parse(Console.ReadLine());
            Console.WriteLine("enter sum");
            for(int i=start;i<=end;i++)
            {
                sum1+=i*i;
            }
            Console.WriteLine($"Sum of square {sum1}");

        }
    }
}