using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProperties
{
    class Person
    {
        private string name;
        private int age;


        public string Name
        {
            get => name;
            set => name = !string.IsNullOrEmpty(value) ? value : "Invalid name";
        }

        public int Age
        {
            get => age;
            set => age = value >= 0 && value < 150 ? age = value : age = -1;
        }


        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        /*
        public string ReturnDetails()
        {
            return $"Name: {Name}\nAge: {Age}";
        }
        */

        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}";
        }

        public override bool Equals(object obj)
        {
            if(obj is Person)
            {
                Person person = obj as Person;
                return Name.Equals(person.Name) && Age == person.Age;
            }
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Jakub", 25);
            //Console.WriteLine(person.ReturnDetails());
            //Console.WriteLine(person.ToString());
            Console.WriteLine(person);

            Person secondPerson = new Person("Jakub", 25);

            if(person.Equals(secondPerson))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }

            Console.ReadLine();
        }
    }
}