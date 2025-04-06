namespace CodeWars.Solution._8kyu;

// Color Ghost
// https://www.codewars.com/kata/53f1015fa9fe02cbda00111a
public class ColorGhostKata
{
    private static readonly Random Random = new();
    private static readonly string[] Colors = ["white", "yellow", "purple", "red"];
    
    public string GetColor() => Colors[Random.Next(0, 4)];
}