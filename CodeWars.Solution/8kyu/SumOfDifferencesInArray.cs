namespace CodeWars.Solution._8kyu;

// Sum of differences in array
// https://www.codewars.com/kata/5b73fe9fb3d9776fbf00009e
public class SumOfDifferencesInArray
{
    public static class Kata
    {
        public static int SumOfDifferences(int[] arr)
        {
            return arr.Length > 1
                ? arr.Max() - arr.Min()
                : 0;
        }
    }
}