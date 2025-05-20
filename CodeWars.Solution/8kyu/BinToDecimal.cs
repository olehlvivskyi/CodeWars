namespace CodeWars.Solution._8kyu;

// Bin to Decimal
// https://www.codewars.com/kata/57a5c31ce298a7e6b7000334
public class BinToDecimal
{
    public static class Program
    {
        public static int binToDec(string s) => Convert.ToInt32(s, 2);
    }
}