using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
namespace MethodPractice
{
    class Program 
    {
        public static void Main(string[] args)
        {
            string opt;
            do
            {
             Console.Write("enter num1 : ");
            double num1=double.Parse(Console.ReadLine());
            Console.Write("enter num2 : ");
            double num2=double.Parse(Console.ReadLine());
            Console.Write("enter Your Choice");
            Console.WriteLine("1.Addition\n 2.Subraction\n 3.Multiplication \n 4.Division \n");
            int operation=int.Parse(Console.ReadLine());
            switch(operation)
            {
                case 1:
                {
                    Console.WriteLine("Addition :"+add(num1,num2));
                    break;

                }
                case 2:
                {
                    Console.WriteLine("Subtractonb:"+sub(num1,num2));
                    break;

                }
                case 3:
                {
                    Console.WriteLine("Multiplication :"+mul(num1,num2));
                    break;

                }
                case 4:
                {
                    Console.WriteLine("Division :"+div(num1,num2));
                    break;

                }
                default:
                {
                    Console.WriteLine("Invalid");
                    break;
                }
            }
            Console.WriteLine("Do you want to continue yes or no");
            opt=Console.ReadLine();
            }while(opt.ToLower()=="yes");
            static double add(double num1,double num2)
            {
                return num1+num2;
            
            } 
            static double sub(double num1,double num2)
            {
                return num1-num2;
            
            } 
            static double mul(double num1,double num2)
            {
                return num1*num2;
            
            } 
            static double div(double num1,double num2)
            {
                return num1/num2;
            
            } 
        }
    }
}
    

