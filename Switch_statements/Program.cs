using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a day of the week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            // Variable we are going be using for the switch statement
            switch (day)
            {
                /*  case 2:
                 *  case 3:
                 *      Console.WriteLine("Wednesday");
                 *      break;
                 *  ^^
                 *  It's equal to -> if (day == 2 || day == 3)
                 */

                case 1:
                    Console.WriteLine("Monday");
                    break;                
                case 2:
                    Console.WriteLine("Tuesday");
                    break;                
                case 3:
                    Console.WriteLine("Wednesday");
                    break;                
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;                
                case 6:
                    Console.WriteLine("Saturday");
                    break;                
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                // Else replacement
                default:
                    Console.WriteLine("Invalid day of the week - enter a value between 1 and 7");
                    break;
            }

            Console.ReadLine();
        }
    }
}
