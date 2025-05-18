namespace CodeWars.Solution._8kyu;

// Count the Monkeys!
// https://www.codewars.com/kata/56f69d9f9400f508fb000ba7
public class CountTheMonkeys
{
    public static class MonkeyCounter
    {
        public static int[] MonkeyCount(int n)
        {
            return Enumerable
                .Range(1, n)
                .ToArray();
        }
    }
}