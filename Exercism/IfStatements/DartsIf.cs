namespace Exercism.IfStatements
{
    public static class DartsIf
    {
        public static int Score(double x, double y)
        {
            double locationSum = (x * x) + (y * y);
            if (locationSum <= 1 && locationSum >= -1)
                return 10;
            else if (locationSum <= 25 && locationSum >= -25)
                return 5;
            else if (locationSum <= 100 && locationSum >= -100)
                return 1;
            else
                return 0;
        }
    }
}
