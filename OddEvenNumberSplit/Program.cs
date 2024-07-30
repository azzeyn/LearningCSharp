using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenNumberSplit
{
    internal class Program
    {
        /*
         * Create two lists with integer data type, one for even numbers, one for odd
         * Loop from 0-20
            * if number is even, add to even list
            * if number is odd, add to odd list
         * Print even list
         * Print odd list
         */

        static void Main(string[] args)
        {
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            for (int i = 0; i <= 500; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers.Add(i);
                }
                else
                {
                    oddNumbers.Add(i);
                }
            }

            Console.WriteLine("Even numbers list: ");

            foreach (int item in evenNumbers)
            {
                Console.Write($"{item}, ");
            }

            Console.WriteLine(Environment.NewLine + "Odd numbers list: ");

            foreach (int item in oddNumbers)
            {
                Console.Write($"{item}, ");
            }
            Console.ReadLine();
        }
    }
}
