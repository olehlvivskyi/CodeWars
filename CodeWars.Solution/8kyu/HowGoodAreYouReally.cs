namespace CodeWars.Solution._8kyu;

// How good are you really?
// https://www.codewars.com/kata/5601409514fc93442500010b
public class HowGoodAreYouReally
{
    public class Kata
    {
        public static bool BetterThanAverage(int[] classPoints, int yourPoints) => yourPoints > classPoints.Average();
    }
}