using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntSumArray
{
    internal class Program
    {
        /*
         * Create and initialise int array of numbers
         * Create a function SumOfNumbers with int return type
         * int array param
         * function should return total of all numbers
         * call in main and output the total
         * extra: check array length
            * return -1 if array empty
            * check return in main and output message
            * do we need to return -1, how else can we make this?
         */

        static void Main(string[] args)
        {
            int[] arr = new int[5]
            {
                1, 2, 3, 4, 100
            };
            
            int total = SumOfNumbers(arr);

            if(total > -1)
            {
                Console.WriteLine($"The sum of the numbers in the given array is: {total}");
            }
            else
            {
                Console.WriteLine("Array is empty");
            }

            if(SumOfNumbers(arr, out int totalV2))
            {
                Console.WriteLine($"The sum of the numbers in the given array is: {totalV2}");
            }
            else
            {
                Console.WriteLine("Array is empty");
            }

            Console.ReadLine();
        }

        static int SumOfNumbers(int[] arr)
        {
            if(arr.Length > 0)
            {
               return arr.Sum();
            }

            return -1;
        }
        static bool SumOfNumbers(int[] arr, out int total)
        {
            total = 0;

            if (arr.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    total += arr[i];
                }

                return true;
            }

            return false;
        }
    }
}
