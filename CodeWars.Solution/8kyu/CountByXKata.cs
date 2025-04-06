namespace CodeWars.Solution._8kyu;

// Count by X
// https://www.codewars.com/kata/5513795bd3fafb56c200049e
public static class CountByXKata
{
    public static int[] CountBy(int x, int n)
    {
        return Enumerable.Range(1, n)
            .Select(number => number * x)
            .ToArray();
    }
}