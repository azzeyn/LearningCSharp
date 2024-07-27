using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_equals_function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello";
            string compare = "Hello";

            if (message.Equals(compare))
            {
                Console.WriteLine("same");
            }
            else
            {
                Console.WriteLine("different");
            }

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            if (!name.Equals(string.Empty))
            {
                Console.WriteLine($"Your name is {name}");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            char[] chars = new char[] { 'H', 'e', 'l', 'l', 'o' };
            object newCompare = new string(chars);

            if (message.Equals(newCompare))
                Console.WriteLine("Same");
            else
                Console.WriteLine("Different");

            if (message == newCompare)
                Console.WriteLine("Same");
            else
                Console.WriteLine("Different");


            Console.ReadLine();
        }
    }
}
