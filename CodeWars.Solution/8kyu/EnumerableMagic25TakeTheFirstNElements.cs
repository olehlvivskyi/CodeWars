namespace CodeWars.Solution._8kyu;

// Enumerable Magic #25 - Take the First N Elements
// https://www.codewars.com/kata/545afd0761aa4c3055001386
public class EnumerableMagic25TakeTheFirstNElements
{
    public static class Kata
    {
        public static int[] Take(int[] arr, int n)
        {
            return arr
                .Take(n)
                .ToArray();
        }
    }
}