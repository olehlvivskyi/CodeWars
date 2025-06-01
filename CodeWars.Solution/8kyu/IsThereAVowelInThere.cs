namespace CodeWars.Solution._8kyu;

// Is there a vowel in there?
// https://www.codewars.com/kata/57cff961eca260b71900008f
public class IsThereAVowelInThere
{
    public class Kata
    {
        private static char[] _vowels = { 'a', 'e', 'i', 'o', 'u' };

        public static object[] IsVow(object[] a)
        {
            return a
                .Select(item => _vowels.Any(v => v == Convert.ToChar(item)) ? Convert.ToChar(item).ToString() : item)
                .ToArray();
        }
    }
}