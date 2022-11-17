using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.Numbers
{
    public static class DifferenceOfSquares
    {
        public static int CalculateSquareOfSum(int max) => (max * (max + 1) / 2) * (max * (max + 1) / 2);

        public static int CalculateSumOfSquares(int max) => (max * (max + 1) * (2 * max + 1)) / 6;

        public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}
