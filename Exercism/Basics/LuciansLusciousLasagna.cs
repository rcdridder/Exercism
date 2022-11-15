using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism
{
    public class LuciansLusciousLasagna
    {
        public int ExpectedMinutesInOven() => 40;
        public int RemainingMinutesInOven(int minutesInOven) => ExpectedMinutesInOven() - minutesInOven;
        public int PreparationTimeInMinutes(int layers) => layers * 2;
        public int ElapsedTimeInMinutes(int layers, int minutesInOven) => (layers * 2) + minutesInOven;
    }
}
