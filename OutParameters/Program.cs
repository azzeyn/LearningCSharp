using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            bool success = test(out num);
            Console.WriteLine(num);
            Console.WriteLine(success);

            List<string> shoppingList = new List<string>
            {
                "Coffee", "Milk", "Cocoa", "Fanta"
            };

            Console.WriteLine(shoppingList.IndexOf("Milk"));

            Console.Write("Enter an item to search: ");
            string itemToSearch = Console.ReadLine();

            if(FindInList(shoppingList, itemToSearch, out int index))
            {
            Console.WriteLine($"{itemToSearch} found on index {index}");
            }
            else
            {
                Console.WriteLine($"Item not found");
            }

            Console.ReadLine();
        }

        static bool FindInList(List<string> shoppingList, string text, out int index)
        {
            index = -1;

            for (int i = 0; i < shoppingList.Count; i++)
            {
                if (shoppingList[i].ToLower().Equals(text.ToLower()))
                {
                    index = i;
                }
            }
            return index > -1;
        }

        static bool TryParse(string input, out int result)
        {
            result = 0;
            return true;
        }

        static bool test(out int num)
        {
           num = 5;
           return true;
        }
    }
}
