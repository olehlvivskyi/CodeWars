namespace CodeWars.Solution._8kyu;

// Contamination #1 -String-
// https://www.codewars.com/kata/596fba44963025c878000039
public class Contamination1String
{
    public class Kata
    {
        public static string Contamination(string text, string character)
        {
            IEnumerable<string> contamination = Enumerable.Repeat(character, text.Length);
            return string.Concat(contamination);
        }
    }
}