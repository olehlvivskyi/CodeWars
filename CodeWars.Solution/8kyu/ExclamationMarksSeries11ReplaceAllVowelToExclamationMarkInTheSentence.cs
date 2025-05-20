using System.Text.RegularExpressions;

namespace CodeWars.Solution._8kyu;

// Exclamation marks series #11: Replace all vowel to exclamation mark in the sentence
// https://www.codewars.com/kata/57fb09ef2b5314a8a90001ed
public class ExclamationMarksSeries11ReplaceAllVowelToExclamationMarkInTheSentence
{
    public static class Kata
    {
        public static string Replace(string s) => Regex.Replace(s, "[aeiou]", "!", RegexOptions.IgnoreCase);
    }
}