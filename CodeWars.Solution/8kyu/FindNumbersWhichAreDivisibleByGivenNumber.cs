namespace CodeWars.Solution._8kyu;

// Find numbers which are divisible by given number
// https://www.codewars.com/kata/55edaba99da3a9c84000003b
public class FindNumbersWhichAreDivisibleByGivenNumber
{
    public class Kata
    {
        public static int[] DivisibleBy(int[] numbers, int divisor)
        {
            return numbers
                .Where(number => number % divisor == 0)
                .ToArray();
        }
    }
}