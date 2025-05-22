namespace CodeWars.Solution._8kyu;

// Sleigh Authentication
// https://www.codewars.com/kata/52adc142b2651f25a8000643
public class SleighAuthentication
{
    public class Sleigh
    {
        public static bool Authenticate(string name, string password) =>
            name == "Santa Claus" && password == "Ho Ho Ho!";
    }
}