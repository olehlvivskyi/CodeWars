namespace CodeWars.Solution._8kyu;

// How many stairs will Suzuki climb in 20 years?
// https://www.codewars.com/kata/56fc55cd1f5a93d68a001d4e
public class HowManyStairsWillSuzukiClimbIn20Years
{
    public class Kata
    {
        public static long StairsIn20(int[][] stairs) => stairs.Sum(arr => arr.Sum()) * 20;
    }
}