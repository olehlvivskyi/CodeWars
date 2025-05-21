using System.Drawing;

namespace CodeWars.Solution._8kyu;

// Geometry Basics: Circle Area in 2D
// https://www.codewars.com/kata/58e3f824a33b52c1dc0001c0
public class GeometryBasicsCircleAreaIn2d
{
    public static class Kata
    {
        public static double CircleArea(Circle circle) => Math.PI * Math.Pow(circle.Radius, 2);
    }
    
    // This class was taken from CodeWars
    public class Circle
    {
        public Point Center { get; private set; }
        public double Radius { get; private set; }
  
        public Circle(Point center, double radius)
        {
            this.Center = center;
            this.Radius = radius;
        }
    }
}