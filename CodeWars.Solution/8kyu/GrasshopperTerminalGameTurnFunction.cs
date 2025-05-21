namespace CodeWars.Solution._8kyu;

// Grasshopper - Terminal Game Turn Function
// https://www.codewars.com/kata/56019d3b2c39ccde76000086
public class GrasshopperTerminalGameTurnFunction
{
    public class Kata
    {
        public static void DoTurn()
        {
            RollDice();
            Move();
            Combat();
            GetCoins();
            BuyHealth();
            PrintStatus();
        }
    }
    
    // These methods are made to avoid error caused by missing implementation.
    private static void BuyHealth() => throw new NotImplementedException();
    private static void Combat() => throw new NotImplementedException();
    private static void GetCoins() => throw new NotImplementedException();
    private static void Move() => throw new NotImplementedException();
    private static void PrintStatus() => throw new NotImplementedException();
    private static void RollDice() => throw new NotImplementedException();
}