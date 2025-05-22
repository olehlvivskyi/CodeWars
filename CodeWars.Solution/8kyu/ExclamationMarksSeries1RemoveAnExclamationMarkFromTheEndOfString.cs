namespace CodeWars.Solution._8kyu;

// Exclamation marks series #1: Remove an exclamation mark from the end of string
// https://www.codewars.com/kata/57fae964d80daa229d000126
public class ExclamationMarksSeries1RemoveAnExclamationMarkFromTheEndOfString
{
    public class Kata
    {
        public static string Remove(string s)
        {
            return s[^1] == '!'
                ? s[..^1]
                : s;
        }
    }
}