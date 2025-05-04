using System.Text.RegularExpressions;

namespace CodeWars.Solution._8kyu;

// Regex count lowercase letters
// https://www.codewars.com/kata/56a946cd7bd95ccab2000055
public class RegexCountLowercaseLetters
{
    public class Kata
    {
        public static int LowercaseCountCheck(string s) => Regex.Matches(s, "[a-z]").Count;
    }
}