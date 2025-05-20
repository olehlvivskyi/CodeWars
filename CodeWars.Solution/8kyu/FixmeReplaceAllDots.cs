using System.Text.RegularExpressions;

namespace CodeWars.Solution._8kyu;

// FIXME: Replace all dots
// https://www.codewars.com/kata/596c6eb85b0f515834000049
public class FixmeReplaceAllDots
{
    public class Kata
    {
        public static string ReplaceDots(string str) => new Regex(@"\.").Replace(str, "-");
    }
}