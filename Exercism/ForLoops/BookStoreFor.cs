namespace Exercism.ForLoops
{
    public static class BookStoreFor
    {
        private static double[] setPrices = { 8, 15.2, 21.6, 25.6, 30 };
        public static decimal Total(IEnumerable<int> books)
        {
            List<double> prices = new();
            for (int i = 5; i > 1; i--)
            {
                int[] sets = CreateSets(books, i);
                double price = CalculateSetsPrice(sets);
                prices.Add(price);
            }
            return Convert.ToDecimal(prices.Min());
        }

        private static int[] CreateSets(IEnumerable<int> books, int maxSetSize)
        {
            List<int> bookCounts = new List<int>() { 0, 0, 0, 0, 0 };
            foreach (int book in books)
            {
                bookCounts[book - 1]++;
            }
            int[] sets = new int[5];
            while (maxSetSize > 0)
            {
                bookCounts = bookCounts.OrderByDescending(amount => amount).ToList();
                if (bookCounts.Where(amount => amount > 0).Count() >= maxSetSize)
                {
                    sets[maxSetSize - 1]++;
                    for (int i = 0; i < maxSetSize; i++)
                    {
                        bookCounts[i]--;
                    }
                }
                else
                    maxSetSize--;
            }
            return sets;
        }

        private static double CalculateSetsPrice(int[] sets)
        {
            double price = 0;
            for (int i = 0; i < sets.Length; i++)
            {
                price += sets[i] * setPrices[i];
            }
            return price;
        }
    }
}
