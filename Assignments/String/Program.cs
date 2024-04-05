using System;
using System.Threading;
namespace String 
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int Count=0;
            Console.WriteLine("Enter input string");
            string input=Console.ReadLine();
            //string[] inputsplit=input.Split('b');
            Console.WriteLine("Enter Input to Search");
            string search=(Console.ReadLine());
            for(int i=0;i<input.Length-1;i++)
            {
                if(input[i]=='l'&& input[i+1]=='a')
                {
                    Count+=1;
                }   
            }
            Console.WriteLine(Count);
        }
    }
}

