using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.FormatException
            //System.OverflowException

            bool looping = true;

            while(looping)
            {
                try
                {
                    Console.Write("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    // Skips this code while conversion was not successful
                    Console.WriteLine(num);

                    looping = false;
                }
            
                catch (FormatException)
                {
                    Console.WriteLine("Please only enter numbers!");
                }

                catch (OverflowException)
                {
                    Console.WriteLine("Please enter a number less than 2 billion!");
                }

                // It will catch every single exception
                catch (Exception)
                {
                    Console.WriteLine("Somehting has went wrong!");
                }
            }


            Console.WriteLine("Goodbye");

            Console.ReadLine();
        }
    }
}
