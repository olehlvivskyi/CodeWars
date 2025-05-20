namespace CodeWars.Solution._8kyu;

// Stringy Strings
// https://www.codewars.com/kata/563b74ddd19a3ad462000054
public class StringyStrings
{
    public class Kata
    {
        public static string Stringy(int size)
        {
            return string.Concat(Enumerable
                .Range(1, size)
                .Select(number => number % 2));
        }
    }
}