using ConsoleAppEmployeePolymorphism.Domain;
using System;

namespace ConsoleAppEmployeePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var developer = new Developer(1001, "Hemang", 20000);
            new Manager(2001, "Ashish", 50000);
        }

        static void PrintSalarySlip(Employee employee)
        {
            Console.WriteLine("id" + employee.Id);
            Console.WriteLine("name" + employee.Name);
            Console.WriteLine("basic" + employee.basicSalary);
            Console.WriteLine("Total Salary" + employee.CalculateTotalSalary());
        }
    }
}
