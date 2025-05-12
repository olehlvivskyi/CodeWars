namespace CodeWars.Solution._8kyu;

// Grasshopper - Personalized Message
// https://www.codewars.com/kata/5772da22b89313a4d50012f7
public class GrasshopperPersonalizedMessage
{
    public class Kata
    {
        public static string Greet(string name, string owner) => name == owner ? "Hello boss" : "Hello guest";
    }
}