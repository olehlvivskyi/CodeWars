namespace CodeWars.Solution._7kyu;

// Find the stray number
// https://www.codewars.com/kata/57f609022f4d534f05000024
public class FindTheStrayNumber
{
    class Solution
    {
        public static int Stray(int[] numbers)
        {
            return numbers
                .GroupBy(x => x)
                .Single(x => x.Count() == 1).Key;
        }
    }
}