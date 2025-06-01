namespace CodeWars.Solution._8kyu;

// pick a set of first elements
// https://www.codewars.com/kata/572b77262bedd351e9000076
public class PickASetOfFirstElements
{
    public class Kata
    {
        public static object[] TakeFirstElements(object[] array, int n = 1) => array.Take(n).ToArray();
    }
}