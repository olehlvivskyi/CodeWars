namespace CodeWars.Solution._8kyu;

// Tip Calculator
// https://www.codewars.com/kata/56598d8076ee7a0759000087
public class TipCalculator
{
    public class Kata
    {
        public static int CalculateTip(double amount, string rating)
        {
            var tip = rating.ToLower() switch
            {
                "excellent" => 0.2,
                "great" => 0.15,
                "good" => 0.1,
                "poor" => 0.05,
                "terrible" => 0,
                _ => -1
            };

            return tip > 0
                ? (int) double.Ceiling(amount * tip)
                : (int) tip;
        }
    }
}