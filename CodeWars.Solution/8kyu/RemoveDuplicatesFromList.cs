namespace CodeWars.Solution._8kyu;

// Remove duplicates from list
// https://www.codewars.com/kata/57a5b0dfcf1fa526bb000118
public class RemoveDuplicatesFromList
{
    public static class Program
    {
        public static int[] distinct(int[] a)
        {
            return a
                .Distinct()
                .ToArray();
        }
    }
}