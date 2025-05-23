using System.Text.RegularExpressions;

namespace CodeWars.Solution._8kyu;

// Simple validation of a username with regex
// https://www.codewars.com/kata/56a3f08aa9a6cc9b75000023
public class SimpleValidationOfAUsernameWithRegex
{
    public class Kata
    {
        public static bool ValidateUsr(string username) => Regex.IsMatch(username, "^[a-z0-9_]{4,16}$");
    }
}