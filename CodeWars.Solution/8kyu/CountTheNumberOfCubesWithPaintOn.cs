namespace CodeWars.Solution._8kyu;

// Count the number of cubes with paint on
// https://www.codewars.com/kata/5763bb0af716cad8fb000580
public class CountTheNumberOfCubesWithPaintOn
{
    // NOTE: Solved with help of JetBrains AI in finding out formula to count not painted boxes.
    public static class Kata
    {
        public static int CountSquares(int cuts)
        {
            return cuts == 0
                ? 1
                : (int) Math.Pow(cuts + 1, 3) - (int) Math.Pow(cuts - 1, 3);
        }
    }
}