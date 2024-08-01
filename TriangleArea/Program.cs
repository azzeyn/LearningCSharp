using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    internal class Program
    {
        /*
         * Ask user for width and height, store them
         * Create function to calculate the area
         * Function should calculate the are using: (width * height) / 2
         * Call in main and print out the area of the triangle
         */

        static void Main(string[] args)
        {
            decimal height = ReadDecimal("height");
            decimal width  = ReadDecimal("width");

            Console.WriteLine($"The are of a triangle equals: {CalculateTheAreaOfTriangle(width: width, height: height)}");

            Console.ReadLine();
        }

        static decimal CalculateTheAreaOfTriangle(decimal width, decimal height)
        {
            return (width * height)/2;
        }

        static decimal ReadDecimal(string message)
        {
            Console.Write($"Enter a {message} of a triangle: ");
            return Convert.ToDecimal(Console.ReadLine());
        }
    }
}
