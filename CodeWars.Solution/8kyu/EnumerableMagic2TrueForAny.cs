namespace CodeWars.Solution._8kyu;

// Enumerable Magic #2 - True for Any?
// https://www.codewars.com/kata/54598e89cbae2ac001001135
public class EnumerableMagic2TrueForAny
{
    public class Kata
    {
        public static bool Any(int[] arr, Func<int,bool> fun) => arr.Any(fun);
    }
}