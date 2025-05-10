namespace CodeWars.Solution._8kyu;

// Square(n) Sum
// https://www.codewars.com/kata/515e271a311df0350d00000f
public class SquareNSum
{
    public static class Kata
    {
        public static int SquareSum(int[] numbers) => numbers.Sum(number => number * number);
    }
}