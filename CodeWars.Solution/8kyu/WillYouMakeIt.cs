namespace CodeWars.Solution._8kyu;

// Will you make it?
// https://www.codewars.com/kata/5861d28f124b35723e00005e
public class WillYouMakeIt
{
    public static class Kata
    {
        public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft) => distanceToPump <= fuelLeft * mpg;
    }
}