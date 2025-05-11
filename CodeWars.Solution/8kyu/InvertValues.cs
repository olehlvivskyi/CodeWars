namespace CodeWars.Solution._8kyu;

// Invert values
// https://www.codewars.com/kata/5899dc03bc95b1bf1b0000ad
public class InvertValues
{
    public static class ArraysInversion
    {
        public static int[] InvertValues(int[] input) => Array.ConvertAll(input, number => -number);
    }
}