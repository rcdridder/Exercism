using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.DoWhileLoops
{
    public static class InterestIsInterestingDoWhile
    {
        public static float InterestRate(decimal balance) => balance switch
        {
            < 0m => .03213f,
            < 1000m => 0.005f,
            < 5000m => 0.01621f,
            _ => 0.02475f,
        };

        public static decimal Interest(decimal balance) => balance * Convert.ToDecimal(InterestRate(balance) / 100);

        public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);

        public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
        {
            int count = 0;
            while (balance < targetBalance)
            {
                balance = AnnualBalanceUpdate(balance);
                count++;
            }
            return count;
        }
    }
}
