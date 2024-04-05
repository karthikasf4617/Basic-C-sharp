// See https://aka.ms/new-console-template for more information

using System ;
using System.IO.Compression;
namespace SwitchCase
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter num1 :");
            double num1=double.Parse(Console.ReadLine());
            Console.Write("Enter num2 :");
            double num2=double.Parse(Console.ReadLine());
            Console.WriteLine("Operands \n 1.+ \n 2.- \n 3.* \n 4./ \n 5.%");
            Console.WriteLine("Enter operand");
            char operand=char.Parse(Console.ReadLine());
            switch(operand)
            {
            case '+':
            {
                Console.WriteLine(num1+num2);
                break;
            }
            case '-':
            {
                Console.WriteLine(num1-num2);
                break;
            }
            case '*':
            {
                Console.WriteLine(num1*num2);
                break;
            }
            case '/':
            {
                Console.WriteLine(num1/num2);
                break;
            }
            case '%':
            {
                Console.WriteLine(num1%num2);
                break;
            }
            default:
            {
                Console.WriteLine("Invalid");
                break;
            }
            }
        }

    }
}

