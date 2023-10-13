// See https://aka.ms/new-console-template for more information
using Exercism.Classes;

BowlingClasses game = new();

var previousRolls = new[]
        {
            0,
            0, //1
            0,
            0, //2
            0,
            0, //3
            0,
            0, //4
            0,
            0, //5
            0,
            0, //6
            0,
            0, //7
            0,
            0, //8
            10, //9
            10, //10
            0,
            1
        };
foreach (int i in previousRolls)
{
    game.Roll(i);
}

Console.WriteLine(game.Score());
