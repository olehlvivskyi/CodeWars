namespace CodeWars.Solution._8kyu;

// Points of Reflection
// https://www.codewars.com/kata/57bfea4cb19505912900012c
public class PointsOfReflection
{
    public class Kata
    {
        public static int[] SymmetricPoint(int[] p, int[] q) => [2 * q[0] - p[0], 2 * q[1] - p[1]];
    }
}