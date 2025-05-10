namespace CodeWars.Solution._8kyu;

// A Needle in the Haystack
// https://www.codewars.com/kata/56676e8fabd2d1ff3000000c
public class ANeedleInTheHaystack
{
    public class Kata
    {
        public static string FindNeedle(object[] haystack)
        {
            var needleIndex = Array.IndexOf(haystack, "needle");
            return $"found the needle at position {needleIndex}";
        }
    }
}