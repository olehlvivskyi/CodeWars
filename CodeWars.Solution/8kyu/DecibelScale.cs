namespace CodeWars.Solution._8kyu;

// Decibel Scale
// https://www.codewars.com/kata/5612a42e746aa62de100001a
public class DecibelScale
{
    public static class Kata
    {
        public static double DbScale(double intensity) => 10 * Math.Log10(intensity / Math.Pow(10, -12));
    }
}