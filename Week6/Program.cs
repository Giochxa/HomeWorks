using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Week6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            ////დაწერეთ პროგრამა რომელიც კონსოლიდან მიიღებს მასივის ზომას , n
            ////რაოდენობის ელემენტს შეინახავს მასივში. შემდეგ ამ მასივიდან გაფილტრავს
            ////ელემენტს ლუწ რიცხვებს შეინახავს 1 მასივში ხოლო კენტებს მეორეში .
            //Console.WriteLine("Enter the length of array: ");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int [] array = new int[size];
            //int[] oddArray=new int[size];
            //int[] evenArray = new int[size];
            //var evenCount = 0;
            //var oddCount = 0;
            //Console.WriteLine($"Enter {size} values for the array:");
            //for (int i = 0; i < size; i++) 
            //{

            //    array[i] = int.Parse(Console.ReadLine());
            //    if (array[i] % 2 == 0)
            //    {
            //        oddArray[evenCount] = array[i];
            //        evenCount++;
            //    }
            //    else
            //    {
            //        evenArray[oddCount] = array[i];
            //        oddCount++;
            //    }
            //}
            //Console.WriteLine("Original Array: ");
            //foreach (int i in array)
            //    Console.WriteLine(i + " ");
            //Console.WriteLine("Odd Array:");
            //foreach (int i in oddArray)
            //    Console.WriteLine(i + " ");
            //Console.WriteLine("Even Array: ");
            //foreach (int i in evenArray)
            //    Console.WriteLine(i + " ");
            #endregion

            #region Task 2
            //დაწერეთ პროგრამა რომელიც მასივში დათვლის თითოეული ელემენტის რაოდენობას და გამოიტანს მათ ჯამს.
            //Console.WriteLine("Enter the length of array: ");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] array = new int[size];
            //Console.WriteLine($"Enter {size} values for the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //// Count the occurrences of each symbol in the string
            //var symbolCounts = array
            //    .GroupBy(c => c)
            //    .OrderBy(g => g.Key);

            //// Display the results
            //Console.WriteLine("Symbol Counts:");
            //foreach (var group in symbolCounts)
            //{
            //    Console.WriteLine($"{group.Key} appears {group.Count()} times sum {group.Sum()}");
            //}
            #endregion

            #region Task 3
            //დაწერეთ პროგრამა რომელიც გვიჩვენებს ტოპ n მონაწილის შედეგს . მაგ(1 2 3 4 5 6 7 8 9 10)
            Console.WriteLine("Enter the Number of Participants: ");
            int number = int.Parse(Console.ReadLine());
            int[] results = new int[number];
            Console.WriteLine($"Enter {number} results of the Participants:");
            for (int i = 0; i < number; i++)
            {
                results[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter how many top results to display:");
            var amount = int.Parse(Console.ReadLine());
            foreach (var item in results.OrderBy(g => g).TakeLast(amount))
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}