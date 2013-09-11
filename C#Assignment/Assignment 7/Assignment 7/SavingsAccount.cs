using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_7
{
    class SavingsAccount
    {
        public double currBalance;
        public static double currInterestRate = 0.04;
        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }
        public static void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }
        public static double GetInterestRate()
        {
            return currInterestRate;
        }
        public void SetInterestRateObj(double newRate)
        {
            currInterestRate = newRate;
        }
        public double GetInterestRateObj()
        {
            return currInterestRate;
        }
    };
}
