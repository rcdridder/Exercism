using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.ForLoops
{
    public class BirdWatcherFor
    {
        private int[] birdsPerDay;
        private static int[] birdsPerWeek = { 0, 2, 5, 3, 7, 8, 4 };

        public BirdWatcherFor(int[] birdsPerDay)
        {
            this.birdsPerDay = birdsPerDay;
        }

        public static int[] LastWeek() => birdsPerWeek;

        public int Today() => birdsPerDay.Last();

        public void IncrementTodaysCount() => birdsPerDay[birdsPerWeek.Length - 1]++;

        public bool HasDayWithoutBirds() => birdsPerDay.Contains(0);


        public int CountForFirstDays(int numberOfDays)
        {
            int sum = 0;
            for (int i = 0; i < numberOfDays; i++)
                sum += birdsPerDay[i];
            return sum;
        }

        public int BusyDays()
        {
            int busyDays = 0;
            foreach (int day in birdsPerDay)
            {
                if (day > 4)
                    busyDays++;
            }
            return busyDays;
        }
    }
}
