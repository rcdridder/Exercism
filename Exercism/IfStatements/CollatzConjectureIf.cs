namespace Exercism.IfStatements
{
    public static class CollatzConjectureIf
    {
        public static int Steps(int number)
        {
            int stepCounter = 0;
            if (number <= 0)
                throw new ArgumentOutOfRangeException();
            while (number != 1)
            {
                if (number % 2 == 0)
                    number /= 2;
                else
                    number = (number * 3) + 1;
                stepCounter++;
            }
            return stepCounter;
        }
    }
}
