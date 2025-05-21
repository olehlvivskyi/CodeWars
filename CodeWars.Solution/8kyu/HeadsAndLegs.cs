namespace CodeWars.Solution._8kyu;

// Heads and Legs
// https://www.codewars.com/kata/574c5075d27783851800169e
public class HeadsAndLegs
{
    public class Kata
    {
        public static object Animals(int heads, int legs)
        {
            if (heads == 0 && legs == 0)
            {
                return new[] { 0, 0 };
            }
            
            if (heads > 0 && legs > 0 && legs % 2 == 0 && legs / heads is >= 2 and <= 4)
            {
                int cows = legs / 2 - heads;
                int chickens = heads - cows;
                return new[] { chickens, cows };
            }
            
            return "No solutions";
        }
    }
}