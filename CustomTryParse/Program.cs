using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTryParse
{
    internal class Program
    {
        /*
         * Create a int and try convert any string to an int
         * Notice the error, write a try..catch handler around it
         * Catch the error and output the error message
         * Without changing the current code
         * 
         * Why is this a bad situation and how can we know if its been converted?
         * 
         * Create a custom try parse function
         * Find the real function and copy return type/params
         * Read the tooltip it gives you, to give you ideas on what to do
         */
        static void Main(string[] args)
        {
            int number = 0;
            bool success = false;

            try
            {
                Console.Write("Enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());
                success = true;
            }
            
            catch (OverflowException e)
            {
                Console.WriteLine($"{e.Message}");
            }

             catch (FormatException e)
            {
                Console.WriteLine($"{e.Message}");
            }

            catch (Exception e)
            {

                Console.WriteLine($"{e.Message}");
            }
            finally
            {
                Console.WriteLine(success ? "Yes" : "Oh, no");
            }
            


            Console.Write("Enter a number: ");
            if(CustomTryParse(Console.ReadLine(), out int num))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("Oh, nah");
            }

            Console.ReadLine();
        }

        static bool CustomTryParse(string s, out int result)
        {
            result = -1;

            try
            {
                result = Convert.ToInt32(s);
                return true;
            }

            catch (Exception)
            {
                return false;
            }
            
        }
    }
}
