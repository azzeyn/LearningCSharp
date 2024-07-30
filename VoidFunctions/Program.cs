using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();

            CreateAndPrintArray();
            Console.ReadLine();
        }

        static void CreateAndPrintArray()
        {
            int[] numbers = new int[5] {0, 1, 2, 3, 4};

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
        }
        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my program");
        }
    }
}
