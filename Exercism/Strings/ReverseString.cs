using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.Strings
{
    public static class ReverseString
    {
        public static string Reverse(string input)
        {
            char[] inputArray = input.ToCharArray();
            string reverseInput = string.Empty;
            for(int i = inputArray.Length - 1; i >= 0; i--)
            {
                reverseInput+= inputArray[i];
            }
            return reverseInput;
        }
    }
}
