namespace Exercism.Chars
{
    public static class IsogramChars
    {
        public static bool IsIsogram(string word)
        {
            word = word.ToLower();
            List<char> chars = new();
            foreach (char c in word)
            {
                if (char.IsLetter(c))
                {
                    if (chars.Contains(c))
                        return false;
                    else
                        chars.Add(c);
                }
            }
            return true;
        }
    }
}
