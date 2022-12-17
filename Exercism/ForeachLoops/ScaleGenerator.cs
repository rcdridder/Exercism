using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.ForeachLoops
{
    public static class ScaleGenerator
    {
        private static string[] sharpLadder = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
        private static string[] flatLadder = { "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "Bb", "B" };
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

        public static string[] Chromatic(string tonic)
        {
            string[] ladder = new string[12];
            if (sharpTonics.ContainsKey(tonic)) 
            {
                int noteIndex = sharpTonics[tonic];
                for (int i = 0; i < ladder.Length; i++)
                {
                    ladder[i] = sharpLadder[noteIndex];
                    noteIndex++;
                    if (noteIndex > 11)
                        noteIndex = 0;
                }
            }
            else if(flatTonics.ContainsKey(tonic))
            {
                int noteIndex = flatTonics[tonic];
                for (int i = 0; i < ladder.Length; i++)
                {
                    ladder[i] = flatLadder[noteIndex];
                    noteIndex++;
                    if (noteIndex > 11)
                        noteIndex = 0;
                }
            }
            else 
                throw new ArgumentException("This is not a valid tonic!");
            return ladder;
        }

        public static string[] Interval(string tonic, string pattern)
        {
            char[] intervals = pattern.ToCharArray();
            int intervalIndex = 0;
            string[] ladder = new string[8];
            if (sharpTonics.ContainsKey(tonic))
            {
            int noteIndex = sharpTonics[tonic];
                for (int i = 0; i < ladder.Length; i++)
                {
                    if (i == 7)
                        ladder[i] = sharpLadder[sharpTonics[tonic]];
                    else
                        ladder[i] = sharpLadder[noteIndex];
                    if (intervalIndex >= intervals.Length)
                        break;
                    if (intervals[intervalIndex] == 'm')
                    {
                        noteIndex++;
                        if (noteIndex == 12)
                            noteIndex = 0;
                    }
                    else if (intervals[intervalIndex] == 'M')
                    {
                        noteIndex += 2;
                        if (noteIndex == 12)
                            noteIndex = 0;
                        if (noteIndex == 13)
                            noteIndex = 1;
                    }
                    else if (intervals[intervalIndex] == 'A')
                    {
                        noteIndex += 3;
                        if (noteIndex == 12)
                            noteIndex = 0;
                        if (noteIndex == 13)
                            noteIndex = 1;
                        if (noteIndex == 14)
                            noteIndex = 2;
                    }
                    intervalIndex++;
                }
            }
            else if (flatTonics.ContainsKey(tonic))
            {
                int noteIndex = flatTonics[tonic];
                for (int i = 0; i < ladder.Length; i++)
                {
                    if (i == 7)
                        ladder[i] = flatLadder[flatTonics[tonic]];
                    else
                        ladder[i] = flatLadder[noteIndex];
                    if (intervalIndex >= intervals.Length)
                        break;
                    if (intervals[intervalIndex] == 'm')
                    {
                        noteIndex++;
                        if (noteIndex == 12)
                            noteIndex = 0;
                    }
                    else if (intervals[intervalIndex] == 'M')
                    {
                        noteIndex += 2;
                        if (noteIndex == 12)
                            noteIndex = 0;
                        if (noteIndex == 13)
                            noteIndex = 1;
                    }
                    else if (intervals[intervalIndex] == 'A')
                    {
                        noteIndex += 3;
                        if (noteIndex == 12)
                            noteIndex = 0;
                        if (noteIndex == 13)
                            noteIndex = 1;
                        if (noteIndex == 14)
                            noteIndex = 2;
                    }
                    intervalIndex++;
                }
            }
            else
                throw new ArgumentException("This is not a valid tonic!");
            return ladder;
        }
    }
}
