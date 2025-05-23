namespace CodeWars.Solution._8kyu;

// Find Nearest square number
// https://www.codewars.com/kata/5a805d8cafa10f8b930005ba
public class FindNearestSquareNumber
{
    public static class Kata
    {
        public static int NearestSq(int n) => (int) Math.Pow(Math.Round(Math.Sqrt(n)), 2);
    }
}