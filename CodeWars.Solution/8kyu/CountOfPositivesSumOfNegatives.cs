namespace CodeWars.Solution._8kyu;

// Count of positives / sum of negatives
// https://www.codewars.com/kata/576bb71bbbcf0951d5000044
public class CountOfPositivesSumOfNegatives
{
    public class Kata
    {
        public static int[] CountPositivesSumNegatives(int[]? input)
        {
            if (input == null || input.Length == 0)
            {
                return [];
            }

            int countOfPositive = input.Count(number => number > 0);
            int sumOfNegative = input.Where(number => number < 0).Sum();
            return [countOfPositive, sumOfNegative];
        }
    }
}