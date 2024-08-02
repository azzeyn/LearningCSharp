using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Jakub";
            int age;
            age = 22;

            PrintDetails(name, age);

            string message = ReadFromConsole("Enter anything: ");
            Console.WriteLine(message);

            Console.ReadLine();

        }
        static void PrintDetails(string name, int age)
        {
            Console.WriteLine($"Your name is {name} and your age is {age}");
            Console.WriteLine($"Your name is {name} and your age is {age}");
            Console.WriteLine($"Your name is {name} and your age is {age}");
            Console.WriteLine($"Your name is {name} and your age is {age}");
        }

        static string ReadFromConsole(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}
