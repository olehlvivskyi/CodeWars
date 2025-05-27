namespace CodeWars.Solution._8kyu;

// Exclamation marks series #2: Remove all exclamation marks from the end of sentence
// https://www.codewars.com/kata/57faece99610ced690000165
public class ExclamationMarksSeries2RemoveAllExclamationMarksFromTheEndOfSentence
{
    public class Kata
    {
        public static string Remove(string s) => s.TrimEnd('!');
    }
}