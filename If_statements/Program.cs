using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Your name is " + name + " and your age is " + age);

 
            if (age < 0 || age > 150)
            {
                Console.WriteLine("Invalid age");
            }
            else
            {
                if (age >= 18 && age <= 25)
                {
                    Console.WriteLine("You are between 18 and 25");
                }
                else if (age >= 26)
                {
                    Console.WriteLine("You are 26 or older");
                }
            }
            */
            Console.Write("Please enter the first number: ");
            int numberA = Convert.ToInt32(Console.ReadLine());  
            
            Console.Write("Please enter the second number: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            int answer = numberA * numberB;

            Console.Write("Value of " + numberA + " x " + numberB + ": ");
            string answerInput = Console.ReadLine();
            int actualAnswer = Convert.ToInt32(answerInput);

            if(answer == actualAnswer)
            {
                Console.WriteLine("You're right!");
            }
            else
            {
                Console.WriteLine("You're wrong :(");
            }    

            Console.ReadLine();
        }
    }
}
