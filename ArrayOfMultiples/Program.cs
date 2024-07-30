using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Define and initialise two integers (num, length)
             * (7, 5) -> [7, 14, 21, 28, 35]
             * Create int array with size length
             * loop through and insert the (loop counter x num) into the array
             * print the final array
             */

            Console.Write("Please enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[length];

            int loopCounter = 1;

            for (int i = 0; i < length; i++, loopCounter++)
            {
                arr[i] = loopCounter * num;
            }

            // It's cleaner to do with a counter = > int counter = 0;
            /*
            for (int i = 1; i <= arr.Length; i++)
            {
                arr[i - 1] = i * num;
            }
            */

            foreach (int item in arr)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }

    }
}
