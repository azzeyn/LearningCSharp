using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace String_iteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "C# is awesome";
            // string is an array of characters
            // Console.WriteLine(message[0]);

            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(100);
            }
            Console.WriteLine();
            Console.WriteLine(message.Contains("C"));

            bool contains = false;

            for (int i = 0; i < message.Length; i++)
            {
                if(message[i].Equals('C'))
                {
                    contains = true;
                }
            }
            Console.WriteLine(contains);

            Console.ReadLine();
        }
    }
}
