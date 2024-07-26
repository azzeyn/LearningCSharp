using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Jacob";
            int age = 22;

            Console.WriteLine($"Your name is {name}, and your age is {age}.");
            Console.ReadLine();
        }
    }
}
