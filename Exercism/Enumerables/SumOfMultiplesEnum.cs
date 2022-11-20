namespace Exercism.Enumerables
{
    public static class SumOfMultiplesEnum
    {
        public static int Sum(IEnumerable<int> multiples, int max)
        {
            List<int> numbers = new();
            int sum = 0;
            foreach (int multiple in multiples)
            {
                if (multiple == 0)
                    continue;
                for (int i = 0; i < max; i++)
                {
                    if (i % multiple == 0 && !numbers.Contains(i))
                    {
                        numbers.Add(i);
                        sum += i;
                    }
                }
            }
            return sum;
        }
    }
}
