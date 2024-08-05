using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        /*
        struct Person
        {
            public string name;
            public int age;

            public Person (string name, int age)
            {
                this.name = name;
                this.age = age; 
            }
            public Person ()
            {

            }
        }
            */
        

        
        class Person
        {
            public string name;
            public int age;

            public Person()
            {

            }
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
            public Person(string name)
            {
                this.name = name;
                this.age = -1;
            }
            public Person(int age)
            {
                this.age = age;
                this.name = "null";
            }


        }
        

        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Person person = new Person(name, age);

            if(!string.IsNullOrEmpty(name))
            {
                Console.WriteLine($"{person.name}");
            }
            
            if(age > -1)
            {
                Console.WriteLine($"{person.age}");
            }

            Console.ReadLine();
        }

    }
}
