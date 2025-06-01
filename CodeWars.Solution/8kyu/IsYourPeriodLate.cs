namespace CodeWars.Solution._8kyu;

// Is your period late?
// https://www.codewars.com/kata/578a8a01e9fd1549e50001f1
public class IsYourPeriodLate
{
    public static class Kata
    {
        public static bool PeriodIsLate(DateTime last, DateTime today, int cycleLength)
        {
            return (today - last)
                .TotalDays > cycleLength;
        }
    }
}