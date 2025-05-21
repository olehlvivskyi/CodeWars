namespace CodeWars.Solution._8kyu;

// Simple Fun #261: Whose Move
// https://www.codewars.com/kata/59126992f9f87fd31600009b
public class SimpleFun261WhoseMove
{
    public class Kata
    {
        public static string WhoseMove(string lastPlayer, bool win)
        {
            return (lastPlayer, win) switch
            {
                ("white", true) => "white",
                ("black", false) => "white",
                ("white", false) => "black",
                ("black", true) => "black",
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}