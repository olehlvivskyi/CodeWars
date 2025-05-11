namespace CodeWars.Solution._8kyu;

// Reversed sequence
// https://www.codewars.com/kata/5a00e05cc374cb34d100000d
public class ReversedSequence
{
    public static class Kata
    {
        public static int[] ReverseSeq(int n) => Enumerable.Range(1, n).Reverse().ToArray();
    }
}