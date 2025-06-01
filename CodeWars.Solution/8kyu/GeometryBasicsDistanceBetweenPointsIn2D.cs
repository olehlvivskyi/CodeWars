using System.Drawing;

namespace CodeWars.Solution._8kyu;

// Geometry Basics: Distance between points in 2D
// https://www.codewars.com/kata/58dced7b702b805b200000be
public class GeometryBasicsDistanceBetweenPointsIn2D
{
    public class Kata
    {
        public static double DistanceBetweenPoints(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
    }
}