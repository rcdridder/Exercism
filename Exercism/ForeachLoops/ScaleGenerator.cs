namespace Exercism.ForeachLoops
{
    public static class ScaleGenerator
    {
        private static string[] sharps = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
        private static string[] flats = { "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "Bb", "B" };
        private static Dictionary<string, int> sharpTonics = new()
        {
            { "C", 0 }, { "G", 7 }, { "D", 2 }, { "A", 9 }, { "E", 4 }, { "B", 11 }, { "F#", 6 },
            { "a", 9 }, { "e", 4 }, { "b", 11 }, { "f#", 6 }, { "c#", 1 }, { "g#", 8 }, { "d#", 3 }
        };
        private static Dictionary<string, int> flatTonics = new()
        {
            { "F", 5 }, { "Bb", 10 }, { "Eb", 3 }, { "Ab", 8 }, { "Db", 1 }, { "Gb", 6 },
            { "d", 2 }, { "g", 7 }, { "c", 0 }, { "f", 5 }, { "bb", 10 }, { "eb", 3 }
        };

        public static string[] Chromatic(string tonic) => TonicShifter(tonic).ToArray();

        public static string[] Interval(string tonic, string pattern)
        {
            List<string> notes = TonicShifter(tonic);
            List<string> scale = new();
            int index = 0;
            foreach (char c in pattern)
            {
                scale.Add(notes[index]);
                if (c == 'm')
                    index++;
                if (c == 'M')
                    index += 2;
                if (c == 'A')
                    index += 3;
            }
            scale.Add(notes[0]);
            return scale.ToArray();
        }

        private static List<string> TonicShifter(string tonic)
        {
            string[] notes;
            int index;
            List<string> shiftedScale = new();
            if (sharpTonics.ContainsKey(tonic))
            {
                notes = sharps;
                index = sharpTonics[tonic];
            }
            else if (flatTonics.ContainsKey(tonic))
            {
                notes = flats;
                index = flatTonics[tonic];
            }
            else
                throw new ArgumentException("Invalid tonic!");
            for (int i = index; i < notes.Length + index; i++)
            {
                shiftedScale.Add(notes[i % notes.Length]);
            }
            return shiftedScale;
        }
    }
}
