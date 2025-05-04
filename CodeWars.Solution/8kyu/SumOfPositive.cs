namespace CodeWars.Solution._8kyu;

// Sum of positive
// https://www.codewars.com/kata/5715eaedb436cf5606000381
public class SumOfPositive
{
    public class Kata
    {
        public static int PositiveSum(int[] arr)
        {
            return arr
                .Where(number => number > 0)
                .Sum();
        }
    }
}