namespace CodeWars.Solution._8kyu;

// Find Multiples of a Number
// https://www.codewars.com/kata/58ca658cc0d6401f2700045f
public class FindMultiplesOfANumber
{
    public class Kata
    {
        public static List<int> FindMultiples(int n, int limit)
        {
            return Enumerable
                .Range(1, limit / n)
                .Select(number => n * number)
                .ToList();
        }
    }
}