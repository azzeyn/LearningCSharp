using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a message you want to print out: ");
            string userMessage = Console.ReadLine();
            Console.Write("Enter how many times do you want to print it: ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());
            
            if (loopCounter <= 0)
            {
                Console.WriteLine("Sorry, please enter a value above 0");
            }
            else
            {
                for (int i = 0; i < loopCounter; i++)
                {
                    Console.WriteLine(userMessage);
                }


            }

            /*
            for(int i = 0; i <= 10; i+=2)
            {
                Console.WriteLine(i); 
            }    
            */

            Console.ReadLine();
        }
    }
}
