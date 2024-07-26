using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Numeric_formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = 1000D / 12.34D;
            
            Console.WriteLine(value);
            // value will be placed where the 0 is and 1000 will be placed where the 1 is
            Console.WriteLine(string.Format("{0:0.00}", value));
            Console.WriteLine(string.Format("{0:0.0}", value));

            // # will trim all the unnecessary zeros
            Console.WriteLine(string.Format("{0:0.#}", value));

            Console.WriteLine("{0:0.000}", value);

            double money = -10D / 3D; //3.333333
            Console.WriteLine(money);
            Console.WriteLine(string.Format("-$10 / $3 = ${0:0.00}", money));
            // The reason it works is because C# recognizes (bcf of capital C) that we want it to be a currency
            Console.WriteLine(money.ToString("C"));
            Console.WriteLine(money.ToString("C0"));
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C2"));

            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("jp-JP")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("pl-PL")));

            Console.ReadLine();
        }
    }
}
