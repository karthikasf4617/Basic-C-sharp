using System;
using System.Reflection.Metadata;
using System.Runtime.Serialization.DataContracts;
namespace Array
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter size of array");
            int size=int.Parse(Console.ReadLine());
            string[] array = new string[] { "Mani", "Ganesh", "Vengat", "Suresh", "Vengat" };
            bool flag=true;
            foreach (string i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == name)
                {
                    flag=false;
                    Console.WriteLine($"Your name is present in {i} index in  the array");
                }
            }
            if(flag)
            {
                Console.WriteLine("Not present");

            }
            
        }
    }
}
