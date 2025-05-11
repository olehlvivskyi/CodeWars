namespace CodeWars.Solution._8kyu;

// Beginner Series #2 Clock
// https://www.codewars.com/kata/55f9bca8ecaa9eac7100004a
public class BeginnerSeries2Clock
{
    public static class Clock
    {
        public static int Past(int h, int m, int s) => (h * 3600 + m * 60 + s) * 1000;
    }
}