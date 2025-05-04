namespace CodeWars.Solution._8kyu;

// Smallest unused ID
// https://www.codewars.com/kata/55eea63119278d571d00006a
public class SmallestUnusedId
{
    public class Kata
    {
        public static int NextId(int[] ids)
        {
            return Enumerable
                .Range(0, ids.Length + 1)
                .First(number => !ids.Contains(number));
        }
    }
}