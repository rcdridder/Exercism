namespace Exercism.Arrays
{
    public static class BinarySearchArray
    {
        public static int Find(int[] input, int value)
        {
            int firstIndex = 0;
            int lastIndex = input.Length - 1;
            while (firstIndex <= lastIndex)
            {
                int m = Convert.ToInt32(Math.Floor(Convert.ToDouble((firstIndex + lastIndex) / 2)));
                if (input[m] < value)
                    firstIndex = m + 1;
                else if (input[m] > value)
                    lastIndex = m - 1;
                else
                    return m;
            }
            return -1;
        }
    }
}
