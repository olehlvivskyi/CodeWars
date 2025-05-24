namespace CodeWars.Solution._8kyu;

// 101 Dalmatians - squash the bugs, not the dogs!
// https://www.codewars.com/kata/56f6919a6b88de18ff000b36
public class HundredOneDalmatiansSquashTheBugsNotTheDogs 
{
    public static class Kata
    {
        public static string HowManyDalmatians(int n)
        {
            return n switch
            {
                <= 10 => "Hardly any",
                <= 50 => "More than a handful!",
                101 => "101 DALMATIONS!!!",
                _ => "Woah that's a lot of dogs!"
            };
        }
    }
}