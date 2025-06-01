namespace CodeWars.Solution._8kyu;

// Gravity Flip
// https://www.codewars.com/kata/5f70c883e10f9e0001c89673
public class GravityFlip
{
    // NOTE: On this Kata I spend a lot of time as I thought I need to find some formula or complex algorithm. Solved with hints.
    public class Kata
    {
        public static int[] Flip(char dir, int[] arr)
        {
            return dir switch
            {
                'R' => arr.OrderBy(x => x).ToArray(),
                'L' => arr.OrderByDescending(x => x).ToArray(),
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}