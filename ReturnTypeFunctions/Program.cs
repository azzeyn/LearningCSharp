using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnTypeFunctions
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.Title = $"{ReturnNameAgePair()}";
            PrintIntroduction();

            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
               numbers[i] =  ReadNumberFromConsole();
            }

            foreach (int item in numbers)
            {
                Console.Write($"{item} ");
            }

            int[] newArr = CreateRandomArray();

            Console.WriteLine();

            foreach (int item in newArr)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }
        

        // split it
        static void Test()
        {
            //conversion
            //calculation
        }

        static void Conversion()
        {
            //conversion
        }
        static void Calculation()
        {
            //calucation
        }

        static int Add()
        {
            return 5 + 5;
        }

        static int[] CreateRandomArray()
        {
            return new int[3] { 1, 2, 3 };
        }
        static int ReadNumberFromConsole()
        {
            Console.Write("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void PrintIntroduction()
        {
            Console.WriteLine($"Hello my name is {ReturnName()} and my age is {ReturnAge()}");
        }

        static int ReturnAge()
        {
            return 22;
        }

        static string ReturnName()
        {
            return "Jacob";
        }

        static string ReturnNameAgePair()
        {
            return $"{ReturnName()} - {ReturnAge()}";
        }
    }
}
