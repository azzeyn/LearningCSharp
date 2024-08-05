using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFunctions
{
    internal class Program
    {
        class Person
        {
            public string name;
            public int age;
            public int number;

            public Person()
            {

            }
            public Person(string name)
            {
                this.name = name;
                this.age = -1;
            }
            public Person(int age)
            {
                this.name = "null";
                this.age = age;
            }
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public Person(string name, int age, int number)
            {
                this.name = name;
                this.age = age;
                this.number = number;
            }

            public string ReturnDetails()
            {
                return $"Name: {name}\nAge: {age}\nNumber: {number}";
            }
        }

        static void Main(string[] args)
        {

            Person person = new Person("Jakub", 22, 50);

            //Console.WriteLine(ReturnDetails(person));
            Console.WriteLine(person.ReturnDetails());

            Console.ReadLine();
        }
        
        /*
        static string ReturnDetails(string name, int age)
        { 
            return $"Name: {name}\nAge: {age}";
        }
        */
        /*static string ReturnDetails(Person person)
        {
            return $"Name: {person.name}\nAge: {person.age}\nNumber: {person.number}";
        }
        */
    }
}
