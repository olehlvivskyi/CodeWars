namespace CodeWars.Solution._8kyu;

// Multiply the number
// https://www.codewars.com/kata/5708f682c69b48047b000e07
public class MultiplyTheNumber
{
    public class Kata
    {
        public static int Multiply(int number) => number * (int) Math.Pow(5, $"{Math.Abs(number)}".Length);
    }
}