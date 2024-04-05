using System;
using System.Transactions;
namespace DateTimeAssignment
{
    class Program 
    {
        public static void Main(string[] args)
        {
            string a;
            DateTime date=new DateTime(2021,8,20,10,40,32);
            Console.WriteLine(date.ToString("yyyy"));
            Console.WriteLine(date.ToString("MM"));
            Console.WriteLine(date.ToString("dd"));
            Console.WriteLine(date.ToString("hh"));
            Console.WriteLine(date.ToString("mm"));
            Console.WriteLine(date.ToString("ss"));
            string quest2=date.ToString("yyyy/MM/dd hh:mm:ss tt");
            string[] quest2split=quest2.Split(new char[]{ '/',' ',':'});
            Console.WriteLine("Reversed");
            for(int i=quest2split.Length-1;i>=0;i--)
            {
                Console.WriteLine(quest2split[i]);
            }
            Console.WriteLine("Enter Date");
            DateTime quest3=DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss",null);
            Console.WriteLine(quest3.ToString("date"));
            Console.WriteLine(quest3.ToString("month"));
            Console.WriteLine(quest3.ToString("year"));
        }
    }
}
