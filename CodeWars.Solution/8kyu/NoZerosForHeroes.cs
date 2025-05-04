namespace CodeWars.Solution._8kyu;

// No zeros for heroes
// https://www.codewars.com/kata/570a6a46455d08ff8d001002
public class NoZerosForHeroes
{
    public class NoBoring 
    {
        public static int NoBoringZeros(int n)
        {
            return n == 0 
                ? 0 
                : int.Parse(n.ToString().TrimEnd('0'));
        }
    }
}