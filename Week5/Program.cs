using System;

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
            //y = x - y; x = x - y;
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
            Console.WriteLine("Enter X");
            var x = Convert.ToDecimal(Console.ReadLine());
            for (int i = 1; i < x; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i*i);
                }
            }
            #endregion
        }
    }
}