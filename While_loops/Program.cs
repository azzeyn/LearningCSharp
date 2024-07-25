using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* For loops are mainly used when you know how many times you are gonna iterate through something,
             * but in while loop you might iterate until the condition is met
             * 
             for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
                int number = 0;
                while (number < 10)
                {
                    Console.WriteLine(number);
                    number++;
                }
             */

            Console.Write("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int answer = firstNumber * secondNumber;
            int answerInput = 0;
            

            // not accurate after uncomm

            /*
            Console.Write("What's the value of " + firstNumber + " x " + secondNumber + "?");
            Console.WriteLine();
            answerInput = Convert.ToInt32(Console.ReadLine());
            while(answerInput != answer)
            {
                Console.Write("Wrong answer, type again: ");
                answerInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine("Congrats, you've guessed the number! :)");
           */

            
            // iterate once - always
            // first iteration does not depend on anything
            do
            {   
                Console.Write("Enter your answer: ");
                answerInput = Convert.ToInt32(Console.ReadLine());
                
                if(answer != answerInput)
                {
                    Console.WriteLine("Close but it was wrong!");
                    Console.WriteLine();
                }

            } while(answerInput != answer);

            Console.ReadLine();
        }
    }
}
