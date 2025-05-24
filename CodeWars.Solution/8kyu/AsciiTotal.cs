namespace CodeWars.Solution._8kyu;

// ASCII Total
// https://www.codewars.com/kata/572b6b2772a38bc1e700007a
public class AsciiTotal
{
    public class Kata
    {
        public static int UniTotal(string str)
        {
            return str
                .Sum(c => c);
        }
    }
}