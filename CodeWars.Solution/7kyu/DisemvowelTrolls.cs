namespace CodeWars.Solution._7kyu;

// Disemvowel Trolls
// https://www.codewars.com/kata/52fba66badcd10859f00097e
public class DisemvowelTrolls
{
    public static class Kata
    {
        private const string Vowels = "aeiou";
        
        public static string Disemvowel(string str)
        {
            return string.Concat(str
                .Where(letter => !Vowels.Contains(char.ToLower(letter))));
        }
    }
}