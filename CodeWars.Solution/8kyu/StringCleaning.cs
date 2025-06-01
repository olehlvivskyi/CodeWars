namespace CodeWars.Solution._8kyu;

// String cleaning
// https://www.codewars.com/kata/57e1e61ba396b3727c000251
public class StringCleaning
{
    public class Kata
    {
        public static string StringClean(string s)
        {
            return string.Concat(s
                .Where(c => !char.IsDigit(c)));
        }
    }
}