using StringComparison = System.StringComparison;

namespace CodeWars.Solution._8kyu;

// The Wide-Mouthed frog!
// https://www.codewars.com/kata/57ec8bd8f670e9a47a000f89
public class TheWideMouthedFrog
{
    public class Kata
    {
        public static string MouthSize(string animal)
        {
            return string.Equals(animal, "alligator", StringComparison.InvariantCultureIgnoreCase)
                ? "small"
                : "wide";
        }
    }
}