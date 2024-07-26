using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse_function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
            */

            bool success = true;

            while (success)
            {
                Console.Write("Enter a number: ");

                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    success = false;
                    Console.WriteLine(num); 
                }
                else
                {
                    Console.WriteLine("Failed to convert!");
                }
            }

            Console.ReadLine();
        }
    }
}
