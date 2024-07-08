using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
namespace Assignment_10._2._2_LINQ_Query_Customers
{

    /*2. Write a program to create a list of employees.Consider a hard coded list.
     * Display all employees who have salary more than $5000 and age< 30.*/

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employee = new List<Employee> {

            new Employee() { Id = 435234, Name = "Juan Silva", Age = 32, Income = 4000 },
            new Employee() { Id = 324554, Name = "Rita Mendez", Age = 27, Income = 7845 },
            new Employee() { Id = 234853, Name = "Luis Marquez", Age = 43, Income = 5829 },

            };

            var employeeQuery =
                   from person in Employee
                   where person.Age > 30 && person.Income > 5000
                   select person;

            Console.WriteLine("Employees with an income greater than $5000 and who are older than 30 years are: \n");

            foreach (Employee employee in employeeQuery)
            {
                Console.WriteLine("Name:" +  employee.Name + " Age:" + employee.Age + " Income:$" + employee.Income);
            }
        }
    }
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Income { get; set; }
    }
}


    

