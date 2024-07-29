using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChecker
{
    internal class Program
    {
                    /*
             * Ask user to enter password, and store
             * Ask user to enter password again, and store
             * Check if they are both contain something
                * If so check if they are the same
                    * If they are, print "Passwords match"
                    * If they are not, print "Passwords do not match"
                * If they are empty, print "Please enter a password."
            */
        static void Main(string[] args)
        {
            Console.Write("Please enter your password: ");
            string firstUserPassword = Console.ReadLine();
            Console.Write("Please enter your password once again: ");
            string secondUserPassword = Console.ReadLine();

            if (!String.IsNullOrEmpty(firstUserPassword))
            {
                if (!String.IsNullOrEmpty(secondUserPassword))
                {
                    if (firstUserPassword.Length >= 6 && secondUserPassword.Length >= 6)
                    {
                        if (firstUserPassword.Equals(secondUserPassword))
                        {
                            Console.WriteLine("Passwords match.");
                        }
                        else
                        {
                            Console.WriteLine("Passwords do not match.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter 6 or more characters");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a password confirmation.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a password.");
            }

            Console.ReadLine();
        }
    }
}
