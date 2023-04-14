using System.Text;

namespace Exercism.Chars
{
    public static class SqueakyCleanChars
    {
        public static string Clean(string identifier)
        {
            StringBuilder sb = new();
            bool previousCharWasDash = false;
            foreach (char c in identifier)
            {
                if (c == ' ')
                    sb.Append('_');
                else if (Char.IsControl(c))
                    sb.Append("CTRL");
                else if (c == '-')
                    previousCharWasDash = true;
                else if (previousCharWasDash)
                {
                    sb.Append(Char.ToUpper(c));
                    previousCharWasDash = false;
                }
                else if (Char.IsLetter(c) && !('α' <= c && c <= 'ω'))
                    sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
