using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int vat = 20;
            const double percentVAT = vat / 100D;

            int balance = 1000;

            // We give it a 100D - so now it's a decimal number
            Console.WriteLine(balance * percentVAT);

            const string version = "v1.0";

            Console.ReadLine();
        }
    }
}
