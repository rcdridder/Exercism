// See https://aka.ms/new-console-template for more information
using Exercism.Arrays;
using Exercism.ExtensionMethods;
using Exercism.Numbers;
using Exercism.Strings;

var array = new[] { 1, 3, 4, 6, 8, 9, 11 };
var value = 1;

Console.WriteLine(BinarySearchArray.Find(array, value));
