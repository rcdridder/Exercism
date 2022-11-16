namespace Exercism.IfStatements
{
    public static class CarsAssembleIfStatement
    {
        const int baseSpeed = 221;
        public static double SuccessRate(int speed) => speed switch
        {
            0 => 0,
            < 5 => 1,
            < 9 => 0.9,
            9 => 0.8,
            10 => 0.77,
            _ => throw new ArgumentOutOfRangeException(),
        };
        public static double ProductionRatePerHour(int speed) => baseSpeed * speed * SuccessRate(speed);
        public static int WorkingItemsPerMinute(int speed) => Convert.ToInt32(Math.Floor(ProductionRatePerHour(speed) / 60));

    }
}
