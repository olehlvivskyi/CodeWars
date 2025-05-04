namespace CodeWars.Solution._8kyu;

// Removing Elements
// https://www.codewars.com/kata/5769b3802ae6f8e4890009d2
public class RemovingElements
{
    public static class Kata
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
            return arr
                .Where((_, index) => index % 2 == 0)
                .ToArray();
        }
    }
}