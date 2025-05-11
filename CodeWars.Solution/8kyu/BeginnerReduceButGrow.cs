namespace CodeWars.Solution._8kyu;

// Beginner - Reduce but Grow
// https://www.codewars.com/kata/57f780909f7e8e3183000078
public class BeginnerReduceButGrow
{
    public class Kata
    {
        public static int Grow(int[] x) => x.Aggregate((result, next) => result * next);
    }
}