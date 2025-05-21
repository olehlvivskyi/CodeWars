namespace CodeWars.Solution._8kyu;

// Enumerable Magic #4 - True for None?
// https://www.codewars.com/kata/545993ee52756d98ca0010e1
public class EnumerableMagic4TrueForNone
{
    public class Kata
    {
        public static bool None(int[] arr, Func<int, bool> fun) => !arr.Any(fun);
    }
}