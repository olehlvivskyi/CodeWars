namespace CodeWars.Solution._8kyu;

// Take the Derivative
// https://www.codewars.com/kata/5963c18ecb97be020b0000a2
public class TakeTheDerivative
{
    public class Kata
    {
        public static string Derive(double coefficient, double exponent) => $"{coefficient * exponent}x^{exponent - 1}";
    }
}