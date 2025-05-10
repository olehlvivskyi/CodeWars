namespace CodeWars.Solution._8kyu;

// Remove First and Last Character
// https://www.codewars.com/kata/56bc28ad5bdaeb48760009b0
public class RemoveFirstAndLastCharacter
{
    public class Kata
    {
        public static string Remove_char(string s) => s[1..^1];
    }
}