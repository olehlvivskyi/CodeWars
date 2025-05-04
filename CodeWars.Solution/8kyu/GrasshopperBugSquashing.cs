namespace CodeWars.Solution._8kyu;

// Grasshopper - Bug Squashing
// https://www.codewars.com/kata/56214b6864fe8813f1000019
public class GrasshopperBugSquashing
{
    public static partial class Kata
    {
        public static int Health = 100;
        public static int Position = 0;
        public static int Coins = 0;
  
        public static void PlayTurn()
        {
            RollDice();
            Move();
            Combat();
            GetCoins();
            BuyHealth();
            PrintStatus();
        }
    }

    // These methods are made to avoid error caused by missing implementation
    private static void BuyHealth() => throw new NotImplementedException();
    private static void Combat() => throw new NotImplementedException();
    private static void GetCoins() => throw new NotImplementedException();
    private static void Move() => throw new NotImplementedException();
    private static void PrintStatus() => throw new NotImplementedException();
    private static void RollDice() => throw new NotImplementedException();
}