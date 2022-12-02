namespace Exercism.Numbers
{
    public static class RomanNumeralsNumbers
    {
        public static string ToRomanNumbers(this int value)
        {
            string[] roman1s = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] roman10s = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] roman100s = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] roman1000s = { "", "M", "MM", "MMM" };

            int thousands = Convert.ToInt32(Math.Floor(value / 1000d));
            int hundreds = Convert.ToInt32(Math.Floor((value - thousands * 1000) / 100d));
            int tens = Convert.ToInt32(Math.Floor((value - thousands * 1000 - hundreds * 100) / 10d));
            int singles = value % 10;

            return $"{roman1000s[thousands]}{roman100s[hundreds]}{roman10s[tens]}{roman1s[singles]}";
        }
    }
}
