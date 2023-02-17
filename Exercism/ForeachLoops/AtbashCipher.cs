namespace Exercism.ForeachLoops
{
    public static class AtbashCipher
    {
        private static char[] firstHalf = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm' };
        private static char[] secondHalf = { 'z', 'y', 'x', 'w', 'v', 'u', 't', 's', 'r', 'q', 'p', 'o', 'n' };
        public static string Encode(string plainValue)
        {
            plainValue = plainValue.ToLower();
            string output = string.Empty;
            int groupCount = 0;
            foreach (char c in plainValue)
            {
                if (char.IsPunctuation(c) || c == ' ')
                    continue;
                else if (char.IsNumber(c))
                    output += c;
                else
                {
                    if (firstHalf.Contains(c))
                        output += secondHalf[Array.IndexOf(firstHalf, c)];
                    else
                        output += firstHalf[Array.IndexOf(secondHalf, c)];
                }

                groupCount++;
                if (groupCount % 5 == 0)
                {
                    output += ' ';
                    groupCount = 0;
                }
            }
            return output.Trim();
        }

        public static string Decode(string encodedValue)
        {
            string output = string.Empty;
            foreach (char c in encodedValue)
            {
                if (c == ' ')
                    continue;
                else if (char.IsNumber(c))
                    output += c;
                else
                {
                    if (firstHalf.Contains(c))
                        output += secondHalf[Array.IndexOf(firstHalf, c)];
                    else
                        output += firstHalf[Array.IndexOf(secondHalf, c)];
                }
            }
            return output;
        }
    }
}
