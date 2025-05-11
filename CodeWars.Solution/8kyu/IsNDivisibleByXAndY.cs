namespace CodeWars.Solution._8kyu;

// Is n divisible by x and y?
// https://www.codewars.com/kata/5545f109004975ea66000086
public class IsNDivisibleByXAndY
{
    public class DivisibleNb 
    {
        public static bool IsDivisible(int n, int x, int y) => n % x == 0 && n % y == 0;
    }
}