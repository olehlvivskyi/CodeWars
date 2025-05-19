namespace CodeWars.Solution._8kyu;

// Difference of Volumes of Cuboids
// https://www.codewars.com/kata/58cb43f4256836ed95000f97
public class DifferenceOfVolumesOfCuboids
{
    public class Kata
    {
        public static int FindDifference(int[] a, int[] b) => Math.Abs(a[0] * a[1] * a[2] - b[0] * b[1] * b[2]);
    }
}