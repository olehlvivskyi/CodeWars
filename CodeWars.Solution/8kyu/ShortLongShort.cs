namespace CodeWars.Solution._8kyu;

// Short Long Short
// https://www.codewars.com/kata/50654ddff44f800200000007
public class ShortLongShort
{
    public static string Solution(string a, string b)
    {
        return a.Length > b.Length
            ? b + a + b
            : a + b + a;
    }
}