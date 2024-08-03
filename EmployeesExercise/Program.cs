using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[1];

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = ReturnEmployee();
            }

            foreach (Employee item in employees)
            {
                OutputEmployeeInfo(item);
            }

            Console.ReadLine();
        }

        static Employee ReturnEmployee()
        {

            int id = StringToIntConversion("ID");
            int age = StringToIntConversion("age");
            int birthMonth = StringToIntConversion("birth month");


            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            return new Employee(id, age, birthMonth, name, surname, email);

        }

        static void OutputEmployeeInfo(Employee employee)
        {
            Console.WriteLine($"{Environment.NewLine}Employee info: ");
            Console.WriteLine($"ID: {employee.id}\nAge: {employee.age}\nBirth month: {employee.birthMonth}\nName: {employee.name}\nSurname: {employee.surname}\nEmail: {employee.email} ");
        }

        static int StringToIntConversion(string message)
        {
            Console.Write($"Enter your {message.ToLower()}: ");
            bool idConversionSuccess = int.TryParse(Console.ReadLine(), out int num);

            while (!idConversionSuccess)
            {
                Console.Write("Please, only enter numbers. Try again: ");
                idConversionSuccess = int.TryParse(Console.ReadLine(), out num);
            }
            return num;
        }

    }

    struct Employee
    {
        public int id;
        public int age;
        public int birthMonth;
        public string name;
        public string surname;
        public string email;

        public Employee(int id, int age, int birthMonth, string name, string surname, string email)
        {
            this.id = id;
            this.age = age;
            this.birthMonth = birthMonth;
            this.name = name;
            this.surname = surname;
            this.email = email;
        }
    }



}
