namespace Exercism.Sets
{
    public static class PangramSets
    {
        public static bool IsPangram(string input)
        {
            List<char> letters = new();
            foreach (char c in input.ToLower())
            {
                if (char.IsLetter(c) && !letters.Contains(c))
                    letters.Add(c);
            }
            if (letters.Count == 26)
                return true;
            else
                return false;
        }
    }
}
