namespace Exercism.ForLoops
{
    public static class ReverseStringFor
    {
        public static string Reverse(string input)
        {
            char[] inputArray = input.ToCharArray();
            string reverseInput = string.Empty;
            for (int i = inputArray.Length - 1; i >= 0; i--)
            {
                reverseInput += inputArray[i];
            }
            return reverseInput;
        }
    }
}
