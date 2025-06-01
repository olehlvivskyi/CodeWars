namespace CodeWars.Solution._8kyu;

// Remove First and Last Character Part Two
// https://www.codewars.com/kata/570597e258b58f6edc00230d
public class RemoveFirstAndLastCharacterPartTwo
{
    public static class Kata
    {
        public static string? Array(string s)
        {
            string[] numbers = s.Split(",");

            return numbers.Length > 2
                ? string.Join(",", numbers[1..^1])
                : null;
        }
    }
}