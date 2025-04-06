namespace CodeWars.Solution._8kyu;

// Are You Playing Banjo?
// https://www.codewars.com/kata/53af2b8861023f1d88000832
public class AreYouPlayingBanjoKata
{
    public static string AreYouPlayingBanjo(string name)
    {
        return name + (name.StartsWith("r", StringComparison.OrdinalIgnoreCase)
            ? " plays banjo"
            : " does not play banjo");
    }
}