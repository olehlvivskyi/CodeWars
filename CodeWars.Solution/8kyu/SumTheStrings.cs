namespace CodeWars.Solution._8kyu;

// Sum The Strings
// https://www.codewars.com/kata/5966e33c4e686b508700002d
public class SumTheStrings
{
    public static class Program
    {
        public static string StringsSum(string s1, string s2)
        {
            int.TryParse(s1, out int number1);
            int.TryParse(s2, out int number2);
            
            return $"{number1 + number2}";
        }
    }
}