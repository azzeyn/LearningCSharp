using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = -1;

            string[] arr =
            {
                "Milk", "Bread", "Cheese", "Soda", "Water"
            };

            Console.Write("Enter an item you want to serach in the shopping list: ");
            string item = Console.ReadLine().ToLower();

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i].ToLower().Equals(item))
                {
                    index = i;
                }
            }

            Console.WriteLine(index > -1 ? $"{arr[index]} was found on index {index}\n" : "Item not found\n");

            Console.WriteLine("Full Item List:\n");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {arr[i]}");
            }

            // Second approach

            int position = Array.IndexOf(arr, item);
            Console.WriteLine();
            Console.WriteLine(position > -1 ? $"{arr[position]} was found on index {position}\n" : "Item not found\n");
            
            Console.WriteLine("Full Item List:\n");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {arr[i]}");
            }

            Console.ReadLine();
        }
    }
}
