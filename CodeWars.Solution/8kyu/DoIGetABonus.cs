namespace CodeWars.Solution._8kyu;

// Do I get a bonus
// https://www.codewars.com/kata/56f6ad906b88de513f000d96
public class DoIGetABonus
{
    public static class Kata
    {
        public static string bonus_time(int salary, bool bonus) => $"${salary * (bonus ? 10 : 1)}";
    }
}