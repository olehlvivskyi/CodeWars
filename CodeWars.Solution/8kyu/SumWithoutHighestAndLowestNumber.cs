namespace CodeWars.Solution._8kyu;

// Sum without highest and lowest number
// https://www.codewars.com/kata/576b93db1129fcf2200001e6
public class SumWithoutHighestAndLowestNumber
{
    public static class Kata
    {
        public static int Sum(int[] numbers)
        {
            return numbers is { Length: > 2 }
                ? numbers.Sum() - numbers.Max() - numbers.Min()
                : 0;
        }
    }
}