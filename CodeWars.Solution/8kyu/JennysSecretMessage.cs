namespace CodeWars.Solution._8kyu;

// Jenny's secret message
// https://www.codewars.com/kata/55225023e1be1ec8bc000390
public class JennysSecretMessage
{
    public static class Kata
    {
        public static string greet(string name)
        {
            return name == "Johnny"
                ? "Hello, my love!"
                : "Hello, " + name + "!";
        }
    }
}