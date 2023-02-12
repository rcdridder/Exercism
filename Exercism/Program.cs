// See https://aka.ms/new-console-template for more information
using Exercism.Chars;
using Exercism.Constructors;
using Exercism.Strings;

RailFenceCipher cipher = new(3);
Console.WriteLine(cipher.Encode("WEAREDISCOVEREDFLEEATONCE"));
Console.WriteLine(cipher.Decode("WECRLTEERDSOEEFEAOCAIVDEN"));
