namespace CodeWars.Solution._7kyu;

// Vowel Count
// https://www.codewars.com/kata/54ff3102c1bad923760001f3
public class VowelCount
{
    public static class Kata
    {
        private const string Vowels = "aeiou";
        
        public static int GetVowelCount(string str) => str.Count(letter => Vowels.Contains(letter));
    }
}