namespace CodeWars.Solution._7kyu;

// Highest and Lowest
// https://www.codewars.com/kata/554b4ac871d6813a03000035
public class HighestAndLowest
{
    public static class Kata
    {
        public static string HighAndLow(string numbers)
        {
            IReadOnlyList<int> numbersAsInt = numbers
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            return $"{numbersAsInt.Min()} {numbersAsInt.Max()}";
        }
    }
}