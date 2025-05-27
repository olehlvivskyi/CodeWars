namespace CodeWars.Solution._8kyu;

// Enumerable Magic #1 - True for All?
// https://www.codewars.com/kata/54598d1fcbae2ae05200112c
public class EnumerableMagic1TrueForAll
{
    public class Kata
    {
        public static bool All(int[] arr, Func<int, bool> fun) => arr.All(fun);
    }
}