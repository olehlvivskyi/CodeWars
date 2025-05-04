namespace CodeWars.Solution._8kyu;

// Reversing Words in a String
// https://www.codewars.com/kata/57a55c8b72292d057b000594
public class ReversingWordsInAString
{
    public class Kata
    {
        public static string Reverse(string text)
        {
            var reversedWords = text
                .Split(' ')
                .Reverse();
            return string.Join(" ", reversedWords);
        }
    }
}