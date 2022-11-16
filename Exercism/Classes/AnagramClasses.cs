namespace Exercism.Classes
{
    public class AnagramClasses
    {
        private string baseWord;
        public AnagramClasses(string baseWord) => this.baseWord = baseWord;

        public string[] FindAnagrams(string[] potentialMatches)
        {
            string[] output = new string[potentialMatches.Length];
            int i = 0;
            foreach (string word in potentialMatches)
            {
                if (IsAnagram(word))
                    output[i] = word;
                i++;
            }
            return output.Where(word => !string.IsNullOrEmpty(word)).ToArray();
        }

        private bool IsAnagram(string word)
        {
            bool isAnagram = true;
            word = word.ToLower();
            baseWord = baseWord.ToLower();
            if (word.Length != baseWord.Length || word == baseWord)
                return false;

            char[] inputLetters = word.ToCharArray();
            char[] baseWordLetters = baseWord.ToCharArray();
            Array.Sort(inputLetters);
            Array.Sort(baseWordLetters);
            int i = 0;
            foreach (char letter in inputLetters)
            {
                if (baseWordLetters[i] != letter)
                    isAnagram = false;
                i++;
            }
            return isAnagram;
        }
    }
}
