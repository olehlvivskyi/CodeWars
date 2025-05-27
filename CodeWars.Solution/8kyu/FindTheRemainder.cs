namespace CodeWars.Solution._8kyu;

// Find the Remainder
// https://www.codewars.com/kata/524f5125ad9c12894e00003f
public class FindTheRemainder
{
    public class Kata
    {
        public static int Remainder(int a, int b) => Math.Max(a, b) % Math.Min(a, b);
    }
}