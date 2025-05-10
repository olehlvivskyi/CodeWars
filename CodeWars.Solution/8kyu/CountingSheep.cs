namespace CodeWars.Solution._8kyu;

// Counting sheep...
// https://www.codewars.com/kata/54edbc7200b811e956000556
public class CountingSheep
{
    public static class Kata
    {
        public static int CountSheeps(bool[] sheeps) => sheeps.Count(sheep => sheep);
    }
}