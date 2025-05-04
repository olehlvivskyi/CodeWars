using System.Numerics;

namespace CodeWars.Solution._8kyu;

// Powers of 2
// https://www.codewars.com/kata/57a083a57cb1f31db7000028
public class PowersOf2
{
    public class Kata
    {
        public static BigInteger[] PowersOfTwo(int n)
        {
            return Enumerable
                .Range(0, n + 1)
                .Select(i => BigInteger.Pow(2, i))
                .ToArray();
        }
    }
}