using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(5);
            Console.WriteLine(result);

            PrintName();

            Console.ReadLine();
        }

        static void PrintName(string name = "Jakub")
        {
            Console.WriteLine($"My name is {name}");
        }

        // [Optional] - by default will give us the basic value for this number
        static int Add(int a, [Optional] int b)
        {
            Console.WriteLine($"a = {a}\nb = {b}");
            return a + b; 
        }
    }
}
