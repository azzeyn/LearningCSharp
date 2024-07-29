using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsNullOrEmpty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            // string name = Console.ReadLine();
            string name = null;  // - This has a value but the content is empty
            Console.WriteLine($"Your name is {name}");

            //if (name != "")
            //{
            //    Console.WriteLine("0");
            //}

           // if(!name.Equals(""))
            //{
             //   Console.WriteLine("1");
           // }

            if(!string.IsNullOrEmpty(name)) // null ""
            {
                if (name.Equals("Jakub"))
                {
                    Console.WriteLine("Correct");
                }
            }

            Console.ReadLine();
        }
    }
}
