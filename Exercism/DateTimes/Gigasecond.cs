﻿namespace Exercism.DateTimes
{
    public static class Gigasecond
    {
        public static DateTime Add(DateTime moment) => moment.AddSeconds(1e9);
    }
}
