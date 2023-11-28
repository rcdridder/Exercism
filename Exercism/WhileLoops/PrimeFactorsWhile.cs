using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.WhileLoops
{
    public static class PrimeFactorsWhile
    {
        public static long[] Factors(long number)
        {
            List<long> numbers = new List<long>();
            while (number % 2 == 0)
            {
                numbers.Add(number);
                number /= 2;
            }

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                while (number % i == 0)
                {
                    numbers.Add((long)i);
                    number /= i;
                }
            }

            if (number > 2)
                numbers.Add(number);

            return numbers.ToArray();
        }
    }
}
