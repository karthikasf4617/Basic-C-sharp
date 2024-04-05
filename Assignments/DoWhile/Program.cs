// See https://aka.ms/new-console-template for more information
using System;
namespace  DoWhile 
{
    class Program 
    {
        private static string option;

        public static void Main(string[] args)
        {
            string option;
            do
            {
                Console.Write("Enter a Number ;");
                int num1=int.Parse(Console.ReadLine());
                if(num1%2==0)
                {
                    Console.WriteLine("Even Number");
                }
                else
                {
                    Console.WriteLine("Odd number");
                }
                Console.WriteLine("Do you want to Continue :yes or No :");
                option=Console.ReadLine();
            }while (option.ToLower()=="yes");
            


        }
    }
}
