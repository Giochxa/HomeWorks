using System;
using System.Linq;

namespace Week5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Console.WriteLine("Enter number to check if it can divided by 5 without reminder");
            //var Number = Convert.ToInt32(Console.ReadLine());
            //const int digit = 5;
            //var reminder = Number % digit;
            //if (reminder == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else Console.WriteLine("No");
            #endregion

            #region Task2
            //Console.WriteLine("Enter X");
            //var x =Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Enter Y");
            //var y = Convert.ToDecimal(Console.ReadLine());
            //decimal sum = x + y;
            //Console.WriteLine("X + Y = " + sum);
            //if (x > y)
            //{
            //    decimal subtract = x - y;
            //    Console.WriteLine("X - Y = " + subtract);
            //}
            //else
            //{
            //    decimal subtract = y - x;
            //    Console.WriteLine("Y - X = " + subtract);
            //}
            //decimal multiplication = x * y;
            //Console.WriteLine("X * Y = " + multiplication);
            //if (x == 0 || y == 0)
            //{

            //    Console.WriteLine("Not Allowed To Divide By Zero");
            //}
            //else if (x > y)
            //{
            //    decimal division = x / y;
            //    Console.WriteLine("X / Y = " + division);
            //}
            //else
            //{
            //    decimal division = x / y;
            //    Console.WriteLine("Y / X = " + division);
            //}
            #endregion

            #region Task3
            //Console.WriteLine("Enter X");
            //var x = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Enter Y");
            //var y = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("x = " + x + "     y = " + y);
            //x = x + y;
            //y = x - y;
            //x = x - y;
            //Console.WriteLine("x = " + x + "     y = " + y);
            #endregion

            #region Task4
            //Console.WriteLine("Enter X");
            //var x = Convert.ToDecimal(Console.ReadLine());
            //for (int i = 1; i < 10; i++) 
            //{
            //    decimal y = x * i;
            //    Console.WriteLine(x + " * " + i + " = " + y);
            //}
            #endregion

            #region Task5
            //Console.WriteLine("Enter X");
            //var x = Convert.ToDecimal(Console.ReadLine());
            //for (int i = 1; i < x; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i*i);
            //    }
            //}
            #endregion

            #region Week 6 task
            //decimal [] arr = new decimal[5];
            //decimal a;
            //decimal sum=0;
            //Console.WriteLine("Enter Array numbers of 5");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    a = Convert.ToDecimal(Console.ReadLine());
            //    arr[i]= a*a;
            //    sum += arr[i]; 
            //}
            //Console.WriteLine("Elements in the Array are ");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine($"Sum of elements is {sum}");

            #endregion
            #region Week6 task 2
            //Console.WriteLine("Enter Word");
            //var word = Console.ReadLine();
            //int symbolCount = word.Count();
            //Console.WriteLine(symbolCount);

            //---------------2-------------------
            //Console.Write("Enter a string: ");
            //string userInput = Console.ReadLine();

            //// Count the occurrences of each symbol in the string
            //var symbolCounts = userInput
            //    .GroupBy(c => c)
            //    .OrderBy(g => g.Key);

            //// Display the results
            //Console.WriteLine("Symbol Counts:");
            //foreach (var group in symbolCounts)
            //{
            //    Console.WriteLine($"{group.Key}: {group.Count()} times");
            //}


            //------------------3----------------------
            //Console.WriteLine("Enter a string:");
            //string input = Console.ReadLine();

            //int count = input.Select(ch => 1).Sum();
            //Console.WriteLine(count);

            #endregion
            #region week6 task 3
            string[] cities = new string[] { "Tbilisi", "Rome", "Gori", "Abasha", "Telavi" };
            Console.WriteLine("Enter the starting character city name starts with: ");
            char start = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the starting character city ends starts with: ");
            char end = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Entered start {start} and end {end} cities are: ");
            var match = cities.Where(str => str.StartsWith(start) && str.EndsWith(end));
            foreach (var item in match)
            {
                Console.WriteLine(item);
            }
            
           #endregion
        }
    }
}