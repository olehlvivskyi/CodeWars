namespace CodeWars.Solution._8kyu;

// Return Two Highest Values in List
// https://www.codewars.com/kata/57ab3c09bb994429df000a4a
public class ReturnTwoHighestValuesInList
{
    public static class Kata
    {
        public static int[] TwoHighest(int[] arr)
        {
            return arr
                .Distinct()
                .OrderByDescending(x => x)
                .Take(2)
                .ToArray();
        }
    }
}