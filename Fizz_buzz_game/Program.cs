using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz_buzz_game
{
    internal class Program
    {
        /*
         * Create a for loop from 1 to X (15)
         * 3 and 5 = FizzBuzz
         * 3 = Fizz
         * 5 = Buzz
         * else = number
         */

        static void Main(string[] args)
        {
            /*
            for (int i = 1; i <= 15; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            */

            // It's more efficient because we're doing this calculation only twice
            // If the rules of the game were happen to change, you can change it in only one place (in the previous example you would have to change it in every single case)

            bool threeDiv = false;
            bool fiveDiv = false;

            for (int i = 1; i <= 100; i++)
            {
                threeDiv = i % 3 == 0;
                fiveDiv = i % 5 == 0;

                if (threeDiv && fiveDiv)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (threeDiv)
                {
                    Console.WriteLine("Fizz");
                }
                else if (fiveDiv)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
