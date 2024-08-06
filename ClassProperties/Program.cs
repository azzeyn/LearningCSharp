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
        

        /*
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        */

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }


        /*
        public void SetName(string name)
        {
            this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name";
        }

        public string GetName()
        {
            return name;
        }

        public void SetAge(int age)
        {
            this.age = age >= 0 && age <= 150 ? age : -1;
        }

        public int GetAge()
        {
            return age;
        }
        */
        
        public string ReturnDetails()
        {
            return $"Name: {Name}\nAge: {Age}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Jakub", 11);
            Console.WriteLine(person.ReturnDetails());


            person.Name = "";
            person.Age = -10;

            Console.WriteLine(person.ReturnDetails());

            Console.WriteLine($"Your name is {person.Name} and your age is {person.Age}");

            Console.ReadLine();
        }
    }
}
