namespace Exercism.Strings
{
    public static class RotationalCipherStrings
    {
        public static string Rotate(string text, int shiftKey)
        {
            if (shiftKey == 0 || shiftKey == 26)
                return text;
            string output = string.Empty;
            foreach (char c in text)
            {
                if (!char.IsLetter(c))
                    output += c;
                else
                {
                    if (char.IsUpper(c))
                        output += Convert.ToChar(((byte)c + shiftKey - 65) % 26 + 65);
                    else
                        output += Convert.ToChar(((byte)c + shiftKey - 97) % 26 + 97);
                }
            }
            return output;
        }
    }
}
