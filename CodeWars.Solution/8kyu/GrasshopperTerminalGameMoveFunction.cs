namespace CodeWars.Solution._8kyu;

// Grasshopper - Terminal game move function
// https://www.codewars.com/kata/563a631f7cbbc236cf0000c2
public class GrasshopperTerminalGameMoveFunction
{
    public class Game
    {
        public static int Move(int position, int roll) => position + roll * 2;
    }
}