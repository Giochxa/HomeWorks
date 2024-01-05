using System;

namespace Week10
{
    interface IFinanceOperations
    {
        public double CalculateLoanPercent(int month, double AmountPerMonth);
        
        public bool CheckUserHistory();
    }
    public class Bank : IFinanceOperations
    {
        public bool CheckUserHistory()
        {
            Random random = new Random();
            return Convert.ToBoolean(random.Next(2) == 0);
        }
        public double CalculateLoanPercent(int month, double AmountPerMonth)
        {
            const int pers = 5;
            double x = month * AmountPerMonth * pers / 100;
            return x;
        }
    }

    public class MicroFinance : IFinanceOperations
    {
        public double CalculateLoanPercent(int month, double AmountPerMonth)
        {
            const int pers = 10;
            int commision = 4;
            double x = month * AmountPerMonth + month * AmountPerMonth * pers / 100 + month * commision;
            return x;
        }

        public bool CheckUserHistory() 
        {
            return true;
        }
    }
}
