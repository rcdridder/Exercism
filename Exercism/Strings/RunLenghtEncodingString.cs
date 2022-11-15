namespace Exercism.Strings
{
    public static class RunLenghtEncodingString
    {
        public static string Encode(string input)
        {
            string output = string.Empty;
            int currentCharCount = 0;
            int nextCharCount = 1;
            int duplicateCharCount = 1;
            while (currentCharCount < input.Length)
            {
                if (nextCharCount == input.Length)
                {
                    output += input[currentCharCount];
                    break;
                }
                if (input[currentCharCount] != input[nextCharCount])
                {
                    output += input[currentCharCount];
                    currentCharCount++;
                    nextCharCount++;
                }
                else
                {
                    while (input[nextCharCount] == input[currentCharCount])
                    {
                        duplicateCharCount++;
                        if (nextCharCount == input.Length - 1)
                            break;
                        else
                            nextCharCount++;
                    }
                    output += duplicateCharCount.ToString() + input[currentCharCount];
                    currentCharCount += duplicateCharCount;
                    nextCharCount++;
                    duplicateCharCount = 1;
                }
            }
            return output;
        }

        public static string Decode(string input)
        {
            string output = string.Empty;
            int currentCharCount = 0;
            string numberString = String.Empty;

            while (currentCharCount < input.Length)
            {
                while (Char.IsDigit(input[currentCharCount]))
                {
                    numberString += input[currentCharCount];
                    currentCharCount++;
                }
                int multiplier = 1;
                if (numberString.Length > 0)
                    multiplier = Convert.ToInt32(numberString);
                for (int i = 0; i < multiplier; i++)
                {
                    output += input[currentCharCount];
                }
                currentCharCount++;
                numberString = String.Empty;
            }
            return output;
        }
    }
}
