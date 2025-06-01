namespace CodeWars.Solution._8kyu;

// Surface Area and Volume of a Box
// https://www.codewars.com/kata/565f5825379664a26b00007c
public class SurfaceAreaAndVolumeOfABox
{
    // NOTE: Solved with help of https://www.wikihow.com/Find-the-Surface-Area-of-a-Box
    public class Kata
    {
        public static int[] Get_size(int w, int h, int d) => [2 * (d * w + d * h + w * h), w * h * d];
    }
}