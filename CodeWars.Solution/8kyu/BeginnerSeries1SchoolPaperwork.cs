namespace CodeWars.Solution._8kyu;

// Beginner Series #1 School Paperwork
// https://www.codewars.com/kata/55f9b48403f6b87a7c0000bd
public class BeginnerSeries1SchoolPaperwork
{
    public static class Paper
    {
        public static int Paperwork(int n, int m)
        {
            return n > 0 && m > 0
                ? n * m
                : 0;
        }
    }
}