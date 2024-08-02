using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintErrorMessages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num);
            }

            catch (FormatException)
            {
                Console.WriteLine("Please only enter numbers!");
            }

            catch (OverflowException)
            {
                Console.WriteLine("Please enter a value under 2 billion!");
            }

            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }


            Console.ReadLine();
        }
    }
}
