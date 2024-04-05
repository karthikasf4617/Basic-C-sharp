// See https://aka.ms/new-console-template for more information
using System;
namespace WhileLoop
{
    class Program 
    {
        public static void Main(string[] args)
        {
             //Question 1
             int i=0;
             while(i<=25)
             {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
                i++;
             }
             //Question 2
             int a;
             Console.Write("Enter valid Number:");
             bool num1=int.TryParse(Console.ReadLine(),out a);
             while(!num1)
             {
                Console.WriteLine("Invalid input.Please again enter a valid format");
                num1=int.TryParse(Console.ReadLine(),out a);
                break;
             }
             
        
        }
    }
}
