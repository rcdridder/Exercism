using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.Arrays
{
    public static class ResistorColor
    {
        private static string[] resistorColors = {"black" , "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
        public static int ColorCode(string color) => Array.IndexOf(resistorColors, color);
        public static string[] Colors() => resistorColors;
    }
}
