namespace CodeWars.Solution._8kyu;

// Calculate average
// https://www.codewars.com/kata/57a2013acf1fa5bfc4000921
public class CalculateAverageKata
{
    public static double FindAverage(double[] array)
    {
        return array.Length == 0 
            ? 0 
            : array.Average();
    }
}