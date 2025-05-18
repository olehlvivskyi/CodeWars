namespace CodeWars.Solution._8kyu;

// Will there be enough space?
// https://www.codewars.com/kata/5875b200d520904a04000003
public class WillThereBeEnoughSpace
{
    public static class Kata
    {
        public static int Enough(int cap, int on, int wait) => Math.Max(0, on + wait - cap);
    }
}