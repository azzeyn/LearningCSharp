using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                // new instance of an integer array with 3 positions
                int[] numbers = new int[5];

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write("Please enter a number: ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }

                Console.WriteLine();

                foreach (int num in numbers)
                {
                    Console.Write($"{num} ");
                }
             * 
             * 
             */

            const int angleCount = 3;
            int angleSum = 0;

            for (int i = 0; i < angleCount; i++)
            {
                Console.Write($"Enter an angle {i + 1}: ");
                angleSum += Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid");

            Console.ReadLine();
        }
    }
}
