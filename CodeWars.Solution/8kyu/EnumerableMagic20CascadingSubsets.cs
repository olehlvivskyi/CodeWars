namespace CodeWars.Solution._8kyu;

// Enumerable Magic #20 - Cascading Subsets
// https://www.codewars.com/kata/545af3d185166a3dec001190
public class EnumerableMagic20CascadingSubsets
{
    static class Kata 
    {
        public static IEnumerable<IEnumerable<int>> EachCons(int[] list, int n)
        {
            for (int i = 0; i <= list.Length - n; i++)
            {
                yield return list
                    .Skip(i)
                    .Take(n);
            }
        }
    }
}