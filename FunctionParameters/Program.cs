using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(56, 64));

            int number = ReadInt("Enter a number");
            Console.WriteLine(number);

            int number2 = ReadInt("Enter an angle");
            Console.WriteLine(number2);

            int firstNum = ReadInt("Enter first number");
            int secondNum = ReadInt("Enter second number");

            Console.WriteLine(Add(firstNum, secondNum));

            string name = ReadString("Enter your name");
            int age = ReadInt("Enter your age");

            string details = UserDetails(name, age);
            Console.WriteLine(details);


            Console.ReadLine();
        }

        static string UserDetails(string name, int age)
        {
            return $"Hello my name is {name} and my age is {age}";
        }

        static string ReadString(string message)
        {
            Console.Write($"{message}: ");
            return Console.ReadLine();
        }

        static int ReadInt(string message)
        {
            Console.Write($"{message}: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

    }
}
