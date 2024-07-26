using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verbatim_string_literal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Backslash is a escape character
            string speech = "He said \"something\"" ;
            Console.WriteLine(speech);
            string path = "C:\\Users\\Jakub\\Desktop\\LearningCSharp\nNew line test";
            Console.WriteLine(path);
            // $ +
            // $"Your name is {name}"
            // "Your name is " + name

            path = @"\Users\Jakub\Desktop\LearningCSharp" + "\nNew line test";
            Console.WriteLine(path);

            string name = @"Hello ""someone"" ";

            // It's okay because it doesn't interrupt the syntax of the language. The character can just be inside the string and to the compiler it's just a char even tho they're similar
            name = "Hello 'someone'";
            Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
