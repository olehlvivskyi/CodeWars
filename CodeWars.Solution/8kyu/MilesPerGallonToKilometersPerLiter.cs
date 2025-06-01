namespace CodeWars.Solution._8kyu;

// Miles per gallon to kilometers per liter
// https://www.codewars.com/kata/557b5e0bddf29d861400005d
public class MilesPerGallonToKilometersPerLiter
{
    public static class Kata
    {
        private const double ImperialGallonInLitters = 4.54609188;
        private const double MileInKilometers = 1.609344;
        
        public static double Converter(int mpg) => double.Round(mpg / ImperialGallonInLitters * MileInKilometers, 2);
    }
}