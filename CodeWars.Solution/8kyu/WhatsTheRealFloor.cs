namespace CodeWars.Solution._8kyu;

// What's the real floor?
// https://www.codewars.com/kata/574b3b1599d8f897470018f6
public class WhatsTheRealFloor
{
    public static class Kata
    {
        public static int GetRealFloor(int n)
        {
            return n switch
            {
                > 13 => n - 2,
                >  0 => n - 1,
                _    => n
            };
        }
    }
}