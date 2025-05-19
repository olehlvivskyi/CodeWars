namespace CodeWars.Solution._8kyu;

// Expressions Matter
// https://www.codewars.com/kata/5ae62fcf252e66d44d00008e
public class ExpressionsMatter
{
    public class Kata
    {
        public static int ExpressionsMatter(int a, int b, int c)
        {
            IReadOnlyList<int> results = [a + b + c, a * b * c, (a + b) * c, a * (b + c)];
            return results.Max();
        }
    }
}