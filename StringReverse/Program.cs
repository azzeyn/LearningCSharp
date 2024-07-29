using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Ask user to input message
             * Print in order
             * Print in reverse
             */
            
            Console.Write("Please enter a message: ");
            string userInput = Console.ReadLine();

            //Console.WriteLine(userInput)

            for (int i = 0; i < userInput.Length; i++)
            {
                Console.Write(userInput[i]);
            }
            Console.WriteLine("-");

            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }


            Console.WriteLine();

            char[] charArray = userInput.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);


            Console.ReadLine();
        }
    }
}
