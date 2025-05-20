namespace CodeWars.Solution._8kyu;

// Capitalization and Mutability
// https://www.codewars.com/kata/595970246c9b8fa0a8000086
public class CapitalizationAndMutability
{
    public class Kata
    {
        public static string CapitalizeWord(string word) => char.ToUpper(word[0]) + word[1..];
    }
}