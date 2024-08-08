using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryScoreboard
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Section 1

            Dictionary<string, int> scores = new Dictionary<string, int>
            {
                {"Jakub", 1 },
                {"Bocier", 6 },
                {"Zbambocier", 35 },
                {"Chrupcio", 96 },
                {"Julcia", 102},
                {"Kropek", 30}
            };

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            if(scores.TryGetValue(name, out int score))
            {
                Console.WriteLine($"{name} has score of {score}");
            }

            else
            {
                Console.WriteLine("Name not found!");
            }
            
            /*
            foreach(KeyValuePair<string, int> kvp in scores)
            {
                Console.WriteLine($"{kvp.Key}\t{kvp.Value}");
            }
            */

            foreach(var item in scores)
            {
                Console.WriteLine($"{item.Key}\t{item.Value}");
            }
            

            Console.ReadLine(); 
            Console.Clear();

            // Section 2

            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            Console.Write("Please enter your score: ");
            int scoreInput = Convert.ToInt32(Console.ReadLine());

            if(!scores.ContainsKey(userName)) 
            {
                scores.Add(userName, scoreInput);
            }

            else
            {
                scores[userName] += scoreInput;
                
            }

            Console.WriteLine();

            foreach (KeyValuePair<string, int> kvp in scores)
            {
                Console.WriteLine($"{kvp.Key}\t{kvp.Value}");
            }
            Console.ReadLine();
            Console.Clear();

            // Section 3

            Console.Write("Enter a name you want to remove: ");
            string nameToRemove = Console.ReadLine();

            if(!scores.Remove(nameToRemove))
            {
                Console.WriteLine("Name does not exist");
            }


            foreach (KeyValuePair<string, int> kvp in scores)
            {
                Console.WriteLine($"{kvp.Key}\t{kvp.Value}");
            }

            Console.ReadLine();
        }
    }
}
