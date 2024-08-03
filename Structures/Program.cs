using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    internal class Program
    {

        struct Person
        {
            public string name;
            public int age;
            public int birthMonth;
            public int number;

            public Person(string name, int age, int birthMonth, int number)
            {
                this.name = name;
                this.age = age;
                this.birthMonth = birthMonth;
                this.number = number;
            }
        }

        static void Main(string[] args)
        {
            /*
            Person person;

            person.name = "jakub";
            person.age = 22;
            person.birthMonth = 6;

            Console.WriteLine($"{person.name} - {person.age} - {person.birthMonth}");

            string newName = "";
            int newAge = 0;
            int birthMonth = 0;

            ReturnPerson(ref newName, ref newAge, ref birthMonth);
            Console.WriteLine($"{newName} - {newAge} - {birthMonth}");
            
            */

            Person person = ReturnPerson();
            Console.WriteLine($"{person.name} - {person.age} - {person.birthMonth} - {person.number}");


            Console.ReadLine();
        }

        static Person ReturnPerson()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
        
            Console.Write("Enter your birth month: ");
            int birthMonth = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("Enter your favorite number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            return new Person(name, age, birthMonth, number);
        }

        /*
        static void ReturnPerson(ref string name, ref int age, ref int birthMonth)
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your birth month: ");
            birthMonth = Convert.ToInt32(Console.ReadLine());

        }
        */
    }
}
