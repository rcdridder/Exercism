using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.Strings
{
    public static class AcronymStrings
    {
        public static string Abbreviate(string phrase)
        {
            public static string Abbreviate(string phrase)
            {
                string output = phrase[0].ToString();
                int index = 0;
                foreach (char c in phrase)
                {
                    if (c == '-' || c == '_' || char.IsWhiteSpace(c))
                    {
                        if (phrase[index + 1] == ' ' ||
                            phrase[index + 1] == '-' ||
                            phrase[index + 1] == '_')
                        {
                            index++;
                            continue;
                        }
                        else
                            output += phrase[index + 1];
                    }
                    index++;
                }
                return output.ToUpper();
            }
        }
    }
}
