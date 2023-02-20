using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.Strings
{
    public static class IsogramStrings
    {
        public static bool IsIsogram(string word)
        {
            word = word.ToLower();
            List<char> chars = new();
            foreach (char c in word)
            {
                if(char.IsLetter(c))
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
