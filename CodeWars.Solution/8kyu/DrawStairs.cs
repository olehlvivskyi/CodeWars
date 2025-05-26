namespace CodeWars.Solution._8kyu;

// Draw stairs
// https://www.codewars.com/kata/5b4e779c578c6a898e0005c5
public class DrawStairs
{
    public class Kata
    {
        public static string DrawStairs(int n)
        {
            return string.Join('\n', Enumerable
                .Range(1, n)
                .Select("I".PadLeft));
        }
    }
}