namespace CodeWars.Solution._8kyu;

// Alan Partridge II - Apple Turnover
// https://www.codewars.com/kata/580a094553bd9ec5d800007d
public class AlanPartridgeIiAppleTurnover
{
    public class Kata
    {
        public static string Apple(object n)
        {
            return Math.Pow(Convert.ToInt32(n), 2) > 1000
                ? "It's hotter than the sun!!"
                : "Help yourself to a honeycomb Yorkie for the glovebox.";
        }
    }
}