using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 23;
            // + - * /
            age += 30;
            Console.WriteLine(age);

            string name = "Aba";
            name += " is programming";
            Console.WriteLine(name);

            // Weird results cause you're trying to add unicode values of chars
            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);

            Console.ReadLine();
        }
    }
}
