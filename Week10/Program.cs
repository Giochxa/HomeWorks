using System;

namespace Week10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var file = new SubFile();
            file.Write();
            file.Read();
            file.Delete();
            file.Edit();

            Console.WriteLine();
            var Loan1 = new Bank();
            var Loan2 = new MicroFinance();
            
            if (Loan1.CheckUserHistory() == true) 
            {
                Console.WriteLine($"Bank loan amount is: { Loan1.CalculateLoanPercent(12, 5)}");
            }

            Console.WriteLine($"MicroFinance loan amount is: {Loan2.CalculateLoanPercent(12, 5)}");

        }
    }
}
