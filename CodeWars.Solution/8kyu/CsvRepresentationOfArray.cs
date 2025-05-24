using System.Text;

namespace CodeWars.Solution._8kyu;

// CSV representation of array
// https://www.codewars.com/kata/5a34af40e1ce0eb1f5000036
public class CsvRepresentationOfArray
{
    public static class Kata
    {
        public static string ToCsvText(int[][] array)
        {
            return string
                .Join("\n", array
                    .Select(number => string.Join(",", number)));
        }
    }
}