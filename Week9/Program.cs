using System;
using System.Collections.Generic;

namespace Week9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company localCompany = new Company(true);

            List<Employee> employees = new List<Employee>
        {
            new Employee("John", "Doe", 30, "developer", new int[] { 8, 8, 8, 8, 8, 0, 0 }),
            new Employee("Jane", "Smith", 25, "manager", new int[] { 8, 8, 8, 8, 8, 0, 0 }),
            // Add more employees as needed
        };

            double totalWeeklySalary = 0;
            double totalTaxes = 0;

            foreach (var employee in employees)
            {
                double weeklySalary = employee.CalculateWeeklySalary();
                double taxes = localCompany.CalculateTaxes(weeklySalary);

                Console.WriteLine($"{employee.Name}'s weekly salary: ${weeklySalary}");
                Console.WriteLine($"Taxes paid by {employee.Name}: ${taxes}");

                totalWeeklySalary += weeklySalary;
                totalTaxes += taxes;
            }

            double averageWeeklySalary = totalWeeklySalary / employees.Count;

            Console.WriteLine($"Total taxes paid by the company: ${totalTaxes}");
            Console.WriteLine($"Average weekly salary for all employees: ${averageWeeklySalary}");
        }
    }
    
}
