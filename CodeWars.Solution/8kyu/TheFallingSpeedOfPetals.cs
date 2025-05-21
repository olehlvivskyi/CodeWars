namespace CodeWars.Solution._8kyu;

// The falling speed of petals
// https://www.codewars.com/kata/5a0be7ea8ba914fc9c00006b
public interface TheFallingSpeedOfPetals
{
    public static class Kata
    {
        public static double SakuraFall(double v)
        {
            return v > 0 
                ? 400 / v 
                : 0;
        }
    }
}