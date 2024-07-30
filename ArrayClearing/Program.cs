using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClearing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] 
            { 
                1, 1, 2, 3, 4, 5, 6, 7, 8, 9,
            };

            Array.Clear(numbers, 5, 5);
            //Array.Clear(numbers, 0, numbers.Length - 2);

            for (int i = 5; i < 10; i++)
            {
                numbers[i] = default;
            }

            /*
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = default;
            }
            */

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }

            Console.ReadLine();
        }
    }
}
