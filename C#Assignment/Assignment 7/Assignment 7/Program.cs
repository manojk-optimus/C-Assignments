using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount s1 = new SavingsAccount (50);   
            SavingsAccount s2 = new SavingsAccount (100);  
            Console .WriteLine( "Interest Rate is: {0}" ,s1.GetInterestRateObj());
            s2.SetInterestRateObj(0.08);  // S2 object also using the same variable currInterestRat because it is static and it is shared
            Console .WriteLine( "Interest Rate is: {0}" ,s1.GetInterestRateObj());
            SavingsAccount s3 = new SavingsAccount (10000.75);
            Console .WriteLine( "Interest Rate is: {0}" , SavingsAccount.GetInterestRate() );
        }
    }
}
