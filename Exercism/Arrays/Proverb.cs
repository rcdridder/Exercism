namespace Exercism.Arrays
{
    public static class Proverb
    {
        public static string[] Recite(string[] subjects)
        {
            if (subjects == Array.Empty<string>())
                return Array.Empty<string>();
            string[] proverb = new string[subjects.Length];
            for (int i = 0; i < subjects.Length - 1; i++)
            {
                proverb[i] = $"For want of a {subjects[i]} the {subjects[i + 1]} was lost.";
            }
            proverb[proverb.Length - 1] = $"And all for the want of a {subjects[0]}.";
            return proverb;
        }
    }
}
