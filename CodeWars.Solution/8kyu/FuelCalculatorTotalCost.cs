namespace CodeWars.Solution._8kyu;

// Fuel Calculator: Total Cost
// https://www.codewars.com/kata/57b58827d2a31c57720012e8
public class FuelCalculatorTotalCost
{
    public class Kata
    {
        public static double FuelPrice(double litres, double pricePerLitre)
        {
            double discount = litres switch
            {
                >= 10 => 0.25,
                >= 8 => 0.2,
                >= 6 => 0.15,
                >= 4 => 0.1,
                >= 2 => 0.05,
                _ => 0
            };
            
            return double.Round(litres * (pricePerLitre - discount), 2);
        }
    }
}