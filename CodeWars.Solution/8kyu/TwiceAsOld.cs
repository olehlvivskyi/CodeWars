namespace CodeWars.Solution._8kyu;

// Twice as old
// https://www.codewars.com/kata/5b853229cfde412a470000d0
public class TwiceAsOld
{
    public class TwiceAsOldSolution
    {
        public static int TwiceAsOld(int dadYears, int sonYears) => Math.Abs(dadYears - sonYears * 2);
    }
}