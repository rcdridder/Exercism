// See https://aka.ms/new-console-template for more information
using Exercism.ExtensionMethods;
using Exercism.Strings;

var candidates = new[] { "gallery", "ballerina", "regally", "clergy", "largely", "leading" };
var sut = new AnagramString("allergy");
var expected = new[] { "gallery", "regally", "largely" };
foreach (string s in sut.FindAnagrams(candidates))
{
    Console.WriteLine(s);
}
