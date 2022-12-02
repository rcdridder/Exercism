using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.FloatingPointNumbers
{
    public static class DartsFloat
    {
        public static int Score(double x, double y)
        {
            double locationSum = (x * x) + (y * y);
            if (locationSum <= 1 && locationSum >= -1)
                return 10;
            else if (locationSum <= 5 && locationSum >= -5)
                return 5;
            else if (locationSum <= 10 && locationSum >= -10)
                return 1;
            else
                return 0;
        }
    }
}
