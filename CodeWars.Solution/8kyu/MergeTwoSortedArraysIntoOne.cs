namespace CodeWars.Solution._8kyu;

// Merge two sorted arrays into one
// https://www.codewars.com/kata/5899642f6e1b25935d000161
public class MergeTwoSortedArraysIntoOne
{
    public class Kata
    {
        public static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            // Union here will just ensure that second array values are not duplicated.
            return arr1
                .Union(arr2)
                .OrderBy(number => number)
                .ToArray();
        }
    }
}