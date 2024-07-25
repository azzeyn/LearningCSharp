using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoringUserData
{
    internal class Program
    {
        /*
         * Define a variable to hold your name
         * Define a variable to hold your phone number
         * Define a variable to hold your age
         * Print variables line-by-line to the screen
         * Extra: define variables using the var keyword
         */
        static void Main(string[] args)
        {
            string name = "Jacob";
            string phoneNumber = "050000000";
            int age = 22;
            Console.WriteLine(name);
            Console.WriteLine(phoneNumber);
            Console.WriteLine(age);

            var intNumber = 5011010;
            Console.WriteLine(intNumber);

            Console.ReadLine();
        }
    }
}
