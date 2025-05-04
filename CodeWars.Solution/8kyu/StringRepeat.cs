namespace CodeWars.Solution._8kyu;

// String repeat
// https://www.codewars.com/kata/57a0e5c372292dd76d000d7e
public class StringRepeat
{
    public static class Program
    {
        public static string RepeatStr(int n, string s) => string.Concat(Enumerable.Repeat(s, n));
    }
}