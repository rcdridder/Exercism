// See https://aka.ms/new-console-template for more information
using Exercism.FloatingPointNumbers;
using Exercism.ForeachLoops;

string[] notesInScale = ScaleGenerator.Interval("d", "MmMMmAm");
foreach(string s in notesInScale)
{
    Console.WriteLine(s);
}
