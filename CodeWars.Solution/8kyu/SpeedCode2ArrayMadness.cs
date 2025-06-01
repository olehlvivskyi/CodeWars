namespace CodeWars.Solution._8kyu;

// SpeedCode #2 - Array Madness
// https://www.codewars.com/kata/56ff6a70e1a63ccdfa0001b1
public class SpeedCode2ArrayMadness
{
    public class Kata
    {
        public static bool ArrayMadness(int[] a, int[] b) => a.Sum(n => n * n) > b.Sum(n => n * n * n);
    }
}