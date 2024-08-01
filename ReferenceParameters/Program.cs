using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int num = 10;
            Assign(ref num, ref name);
            Console.WriteLine(num);
            Console.WriteLine(name);
            */

            string name = "";

            Console.Write("Enter your new name: ");
            string newName = Console.ReadLine();

            if (ChangeName(ref name, newName))
            {
                Console.WriteLine($"You've changed your name to: {newName}");
            }
            else
            {
                Console.WriteLine("New name cannot be empty or null!");
            }

            Console.ReadLine();
        }

        static bool ChangeName(ref string name, string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                name = newName;
                // return jumps to the end of the function
                return true;
            }
            return false;
        }

        static void Assign(ref int num, ref string name)
        {
            num = 20;
            name = "Jakub";
        }
    }
}
