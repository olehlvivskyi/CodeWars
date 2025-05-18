namespace CodeWars.Solution._8kyu;

// Find the first non-consecutive number
// https://www.codewars.com/kata/58f8a3a27a5c28d92e000144
public class FindTheFirstNonConsecutiveNumber
{
    public class Kata
    {
        public static object? FirstNonConsecutive(int[] arr)
        {
            for (int index = 1; index < arr.Length; index++)
            {
                if (arr[index] - arr[index - 1] != 1) return arr[index];
            }
        
            return null;
        }
    }
}