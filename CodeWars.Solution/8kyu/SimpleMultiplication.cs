namespace CodeWars.Solution._8kyu;

// Simple multiplication
// https://www.codewars.com/kata/583710ccaa6717322c000105
public class SimpleMultiplication
{
    public class Multiplier
    {
        public static int Multiply(int x)
        {
            return x % 2 == 0
                ? x * 8
                : x * 9;
        }
    }
}