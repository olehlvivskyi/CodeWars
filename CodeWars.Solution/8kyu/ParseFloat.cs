namespace CodeWars.Solution._8kyu;

// Parse float
// https://www.codewars.com/kata/57a386117cb1f31890000039
public class ParseFloat
{
    public class Kata
    {
        public static double? ParseF(object? s = null)
        {
            return double.TryParse(s?.ToString(), out double result)
                ? result
                : null;
        }
    }
}