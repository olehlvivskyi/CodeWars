namespace CodeWars.Solution._8kyu;

// Super Duper Easy
// https://www.codewars.com/kata/55a5bfaa756cfede78000026
public class SuperDuperEasy
{
    public class Kata
    {
        public static string Problem(String a)
        {
            return double.TryParse(a, out double n)
                ? $"{n * 50 + 6}"
                : "Error";
        }
    }
}