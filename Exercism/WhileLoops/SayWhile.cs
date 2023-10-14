namespace Exercism.WhileLoops
{
    public static class SayWhile
    {
        static string[] basicNumbers = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen" };
        static string[] multiplicants = { "", "teen", "twen", "thir", "for", "fif", "six", "seven", "eigh", "nine" };
        public static string InEnglish(long number)
        {
            string output = number switch
            {
                < 0 => throw new ArgumentOutOfRangeException(),
                0 => "zero",
                < 15 => basicNumbers[number],
                < 20 => $"{multiplicants[number % 10]}{multiplicants[1]}",
                < 100 => TwentyToHundred(number),
                < 1_000 => HundredToThousand(number),
                < 1_000_000 => ThousandToMillion(number),
                < 1_000_000_000 => MillionToBillion(number),
                < 1_000_000_000_000 => Billions(number),
                _ => throw new ArgumentOutOfRangeException()
            };
            return output.TrimEnd();
        }

        private static string TwentyToHundred(long number)
        {
            if (number % 10 == 0)
                return $"{multiplicants[(int)number / 10]}ty";
            else
                return $"{multiplicants[(int)number / 10]}ty-{basicNumbers[number % 10]}";
        }

        private static string HundredToThousand(long number)
        {
            long modHundred = number % 100;
            string output = $"{basicNumbers[(int)number / 100]} hundred";
            if (modHundred < 15)
                output += $" {basicNumbers[modHundred]}";
            else
                output += $" {TwentyToHundred(modHundred)}";
            return output;
        }

        private static string ThousandToMillion(long number)
        {
            long thousands = (int)number / 1000;
            long modThousand = number % 1000;

            string output = ThousandMultiplicant(thousands);
            output += " thousand";

            if (modThousand < 15)
                output += $" {basicNumbers[modThousand]}";
            else if (modThousand < 100)
                output += $" {TwentyToHundred(modThousand)}";
            else
                output += $" {HundredToThousand(modThousand)}";

            return output;
        }

        private static string MillionToBillion(long number)
        {
            long millions = (int)number / 1000_000;
            long modMillion = number % 1000_000;

            string output = ThousandMultiplicant(millions);
            output += " million ";

            if (modMillion < 15)
                output += $" {basicNumbers[modMillion]}";
            else if (modMillion < 100)
                output += $" {TwentyToHundred(modMillion)}";
            else if (modMillion < 1000)
                output += $" {HundredToThousand(modMillion)}";
            else
                output += $"{ThousandToMillion(modMillion)}";

            return output;
        }

        private static string Billions(long number)
        {
            long billions = number / 1000_000_000;
            long modBillion = number % 1000_000_000;

            string output = ThousandMultiplicant(billions);
            output += " billion ";

            if (modBillion < 15)
                output += $" {basicNumbers[modBillion]}";
            else if (modBillion < 100)
                output += $" {TwentyToHundred(modBillion)}";
            else if (modBillion < 1000)
                output += $" {HundredToThousand(modBillion)}";
            else if (modBillion < 1_000_000)
                output += $"{ThousandToMillion(modBillion)}";
            else
                output += $"{MillionToBillion(modBillion)}";

            return output;
        }

        private static string ThousandMultiplicant(long multiplicant)
        {
            if (multiplicant < 15)
                return $"{basicNumbers[multiplicant]}";
            else if (multiplicant < 100)
                return $"{TwentyToHundred(multiplicant)}";
            else
                return $"{HundredToThousand(multiplicant)}";
        }
    }
}
