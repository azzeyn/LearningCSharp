using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The compiler will figure it out what type it needs to be based on the value
            var age = 50;
            var bigNumber = 90000L;
            var negative = -55.2D;
            var precision = 5.001F;
            var money = 14.99M;
            var name = "Aba";
            var ch = 'c';

            Console.ReadLine();
        }
    }
}
