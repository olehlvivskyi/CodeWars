namespace CodeWars.Solution._8kyu;

// Thinkful - Number Drills: Blue and red marbles
// https://www.codewars.com/kata/5862f663b4e9d6f12b00003b
public class ThinkfulNumberDrillsBlueAndRedMarbles
{
    public static class BlueAndRedMarbles 
    {
        public static double GuessBlue(uint blueStart, uint redStart, uint bluePulled, uint redPulled)
        {
            uint blueRemaining = blueStart - bluePulled;
            uint totalRemaining = blueStart + redStart - bluePulled - redPulled;
            
            return (double) blueRemaining / totalRemaining;
        }
    }
}