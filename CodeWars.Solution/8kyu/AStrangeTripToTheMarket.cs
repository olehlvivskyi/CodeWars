namespace CodeWars.Solution._8kyu;

// A Strange Trip to the Market
// https://www.codewars.com/kata/55ccdf1512938ce3ac000056
public class AStrangeTripToTheMarket
{
    public static class Kata 
    {
        public static bool IsLockNessMonster(string sentence)
        {
            return sentence
                .ToLower()
                .Contains("tree fiddy") || sentence.Contains("3.50") || sentence.Contains("three fifty");
        }
    }
}