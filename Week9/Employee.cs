using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9
{
    public class Employee
    {
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }
        public string Position { get; }
        public int[] WorkedHours { get; }

        public Employee(string name, string surname, int age, string position, int[] workedHours)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Position = position;
            WorkedHours = workedHours;
        }

        public double CalculateWeeklySalary()
        {
            double hourlyRate = GetHourlyRate();
            double overtimeRate = 5;
            double weekendMultiplier = 2;
            int maxRegularHours = 40;
            double bonusPercentage = 0.2;

            double totalSalary = 0;

            for (int i = 0; i < WorkedHours.Length; i++)
            {
                double dailySalary = 0;

                if (i < 5) // Weekdays
                {
                    dailySalary += WorkedHours[i] * hourlyRate;

                    if (WorkedHours[i] > maxRegularHours)
                    {
                        // Overtime bonus
                        dailySalary += (WorkedHours[i] - maxRegularHours) * overtimeRate;
                    }
                }
                else // Weekends
                {
                    dailySalary += WorkedHours[i] * hourlyRate * weekendMultiplier;
                }

                totalSalary += dailySalary;
            }

            if (totalSalary > 50 * maxRegularHours) // Bonus for working more than 50 hours
            {
                totalSalary *= (1 + bonusPercentage);
            }

            return totalSalary;
        }

        private double GetHourlyRate()
        {
            switch (Position.ToLower())
            {
                case "manager":
                    return 40;
                case "developer":
                    return 30;
                case "tester":
                    return 20;
                default:
                    return 10;
            }
        }
    }
}
