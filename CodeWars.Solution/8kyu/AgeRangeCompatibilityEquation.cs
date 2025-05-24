namespace CodeWars.Solution._8kyu;

// Age Range Compatibility Equation
// https://www.codewars.com/kata/5803956ddb07c5c74200144e
public class AgeRangeCompatibilityEquation
{
    public class Kata
    {
        public static string DatingRange(int age)
        {
            return age > 14
                ? $"{age / 2 + 7}-{2 * (age - 7)}"
                : $"{(int) (age - 0.1 * age)}-{(int) (age + 0.1 * age)}";
        }
    }
}