using System.Text.RegularExpressions;

namespace CodeWars.Solution._8kyu;

// validate code with simple regex
// https://www.codewars.com/kata/56a25ba95df27b7743000016
public class ValidateCodeWithSimpleRegex
{
    public class Kata
    {
        public static bool ValidateCode(string code) => Regex.IsMatch(code, @"^[123]{1}");
    }
}