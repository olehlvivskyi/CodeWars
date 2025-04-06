namespace CodeWars.Solution._8kyu;

// Find the Slope
// https://www.codewars.com/kata/55a75e2d0803fea18f00009d
public class FindTheSlopeKata
{
    public string slope(int[] points)
    {
        return points[2] == points[0] 
            ? "undefined" 
            : $"{(points[3] - points[1]) / (points[2] - points[0])}";
    }
}