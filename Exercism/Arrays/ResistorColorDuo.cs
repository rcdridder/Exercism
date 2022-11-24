namespace Exercism.Arrays
{
    public static class ResistorColorDuo
    {
        public static int Value(string[] colors) => GetColorValue(colors[0]) * 10 + GetColorValue(colors[1]);

        private static int GetColorValue(string color)
        {
            switch (color.ToLower())
            {
                case "black": return 0;
                case "brown": return 1;
                case "red": return 2;
                case "orange": return 3;
                case "yellow": return 4;
                case "green": return 5;
                case "blue": return 6;
                case "violet": return 7;
                case "grey": return 8;
                case "white": return 9;
                default: throw new ArgumentException("Invalid color.");
            }
        }
    }
}
