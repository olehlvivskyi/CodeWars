namespace CodeWars.Solution._8kyu;

// Keep up the hoop
// https://www.codewars.com/kata/55cb632c1a5d7b3ad0000145
public class KeepUpTheHoop
{
    public class Kata
    {
        public static string HoopCount(int n)
        {
            return n >= 10
                ? "Great, now move on to tricks"
                : "Keep at it until you get it";
        }
    }
}