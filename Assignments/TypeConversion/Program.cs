// See https://aka.ms/new-console-template for more information
using System;
namespace TypeConversion
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Your Name :");
            string name=Console.ReadLine();
            Console.Write("Enter Age :");
            int age=int.Parse(Console.ReadLine());
            Console.Write("Enter mark of subject1 : ");
            int mark1=int.Parse(Console.ReadLine());
            Console.Write("Enter mark of subject2 :");
            int mark2=int.Parse(Console.ReadLine());
            Console.Write("Enter mark of subject3 :");
            int mark3=int.Parse(Console.ReadLine());
            Console.Write("Enter Grade :");
            char grade=char.Parse(Console.ReadLine());
            Console.Write("Enter mobile number :");
            long mobile=long.Parse(Console.ReadLine());
            Console.Write("Enter Mail Id :");
            int total=mark1+mark2+mark3;
            float total1=(float)total;
            float avg=total1/3;
            string mail=Console.ReadLine();
            Console.WriteLine("Trainee Details Are :");
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"Mobile :{mobile}");
            Console.WriteLine($"Marks1 : {mark1}");
            Console.WriteLine($"Marks2 : {mark2}");
            Console.WriteLine($"Marks3 : {mark3}");
            Console.WriteLine($"Total : {total}");
            Console.WriteLine($"Average : {avg}");


        }
    }
}
