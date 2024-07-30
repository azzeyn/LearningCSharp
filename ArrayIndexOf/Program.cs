using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayIndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                90, 20, 3, 4, 5, 6, 7, 8
            };

            Console.Write("Enter number to search: ");
            int searchNumb = Convert.ToInt32(Console.ReadLine());

            // int position = Array.IndexOf(numbers, searchNumb);
            
            int position = Array.IndexOf(numbers, searchNumb, 1, 2);

            if(position == -1)
            {
                Console.WriteLine("Given number doesn't exist in this array");
            }
            else
            {
                Console.WriteLine($"Number {searchNumb} has been found at the position: {position + 1}");
            }
            

            /*
            int position = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] == searchNumb)
                {
                    position = i;
                    break;
                }
            }

            if (position == -1)
            {
                Console.WriteLine("Given number doesn't exist in this array");
            }

            else
            {
                Console.WriteLine($"Number {searchNumb} has been found at the position: {position + 1}");
            }
            */

            Console.ReadLine();
        }
    }
}
