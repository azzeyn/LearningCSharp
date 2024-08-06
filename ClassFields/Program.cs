using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFields
{
    internal class Program
    {

        class Person
        {
            private string name;
            private int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            /*
            public void SetName(string name)
            {
                this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name";
            }

            
            public void SetAge(int age)
            {
                this.age = age >= 0 && age <= 130 ? age : -1;
            }
            
            public int GetAge()
            {
                return age;
            }

            public string GetName()
            {
                return name;
            }

            public string ReturnDetails()
            {
                return $"Name {name}\nAge: {age}";
            }
            */

            public int GetAge() => age;

            public string GetName() => name;

            public string ReturnDetails() => $"Name: {name}\nAge: {age}";
            
            public void SetAge(int age) => this.age = age >= 0 && age <= 130 ? age : -1;

            public void SetName(string name) => this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name";


        }
        static void Main(string[] args)
        {
            Person person = new Person("Jakub", 22);
            Console.WriteLine(person.ReturnDetails());

            //person.name = "Harry";
            //person.age = 25;
            person.SetName("Aba");
            person.SetAge(25);

            Console.WriteLine(person.ReturnDetails());
            Console.WriteLine($"Your name is {person.GetName()} and your age is {person.GetAge()}");

            Console.ReadLine();
        }
    }
}
