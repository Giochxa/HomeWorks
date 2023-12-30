using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9
{
    public class Company
    {
        public bool IsLocal { get; }

        public Company(bool isLocal)
        {
            IsLocal = isLocal;
        }

        public bool IsLocalCompany()
        {
            return IsLocal;
        }

        public double CalculateTaxes(double totalSalary)
        {
            double taxRate = IsLocal ? 0.18 : 0.05;
            return totalSalary * taxRate;
        }
    }
}
