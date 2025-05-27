using System.Text.RegularExpressions;

namespace CodeWars.Solution._8kyu;

// Exclamation marks series #6: Remove n exclamation marks in the sentence from left to right
// https://www.codewars.com/kata/57faf7275c991027af000679
public class ExclamationMarksSeries6RemoveNExclamationMarksInTheSentenceFromLeftToRight
{
    public class Kata
    {
        public static string Remove(string s, int n)
        {
            return string.Concat(s
                .Where(c => c != '!' || n-- > 0));
        }
    }
}