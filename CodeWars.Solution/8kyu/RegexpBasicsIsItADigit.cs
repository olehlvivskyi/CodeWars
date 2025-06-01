using System.Text.RegularExpressions;

namespace CodeWars.Solution._8kyu;

// Regexp Basics - is it a digit?
// https://www.codewars.com/kata/567bf4f7ee34510f69000032
public static class RegexpBasicsIsItADigit;

public static class Kata
{
    public static bool Digit(this string s) => Regex.IsMatch(s, @"^\d\z");
}