namespace CodeWars.Solution._8kyu;

// Pole Vault Starting Marks
// https://www.codewars.com/kata/5786f8404c4709148f0006bf
public class PoleVaultStartingMarks
{
    // Note: This is the only 8kyu Kata I have not solved due to timeout (which I set for every task).
    class PoleVault
    {
        public static double StartingMark(double bodyHeight)
        {
            double m = (10.67 - 9.45) / (1.83 - 1.52);
            double b = 9.45 - m * 1.52;
            double result = m * bodyHeight + b;
            
            return Math.Round(result, 2);
        }
    }
}