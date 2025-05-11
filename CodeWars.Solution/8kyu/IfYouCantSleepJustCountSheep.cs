namespace CodeWars.Solution._8kyu;

// If you can't sleep, just count sheep!!
// https://www.codewars.com/kata/5b077ebdaf15be5c7f000077
public class IfYouCantSleepJustCountSheep
{
    public static class Kata
    {
        public static string CountSheep(int n)
        {
            return string.Concat(Enumerable
                .Range(1, n)
                .Select(number => $"{number} sheep..."));
        }
    }
}