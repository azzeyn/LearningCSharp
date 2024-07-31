using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameInput = "Jakub";
            int ageInput = 22;
            string addressInput = "1 Something Road";

            PrintDetails(address: addressInput,
                         name: nameInput,
                         age: ageInput);

            Console.ReadLine();
        }

        static void PrintDetails(string name, int age, string address)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Address: {address}");
        }
    }
}
