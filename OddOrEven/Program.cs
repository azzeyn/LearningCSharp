using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    internal class Program
    {
        /*
         * Create & initaliste two ints
         * Make a variable to work out the remainder
         * Output remainder to the screen
         * Change the first int variable to another number
            * and recalculate the remainder
            * output new remainder to the screen    
         */
        static void Main(string[] args)
        {
            int firstNumber = 10;
            int secondNumber = 2;
            int remainder = firstNumber % secondNumber;
            Console.WriteLine(remainder);

            firstNumber = 15;
            remainder = firstNumber % secondNumber;
            Console.WriteLine(remainder);

            Console.ReadLine();
        }
    }
}
