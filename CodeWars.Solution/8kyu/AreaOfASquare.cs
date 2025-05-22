namespace CodeWars.Solution._8kyu;

// Area of a Square
// https://www.codewars.com/kata/5748838ce2fab90b86001b1a
public class AreaOfASquare
{ 
    // Solved with help of https://www.ncl.ac.uk/webtemplate/ask-assets/external/maths-resources/core-mathematics/geometry/geometry-of-a-circle.html
    public class Kata
    {
        public static double SquareArea(double A)
        {
            double circumference = 4 * A;
            double radius = circumference / Math.PI / 2;
            return double.Round(radius * radius, 2);
        }
    }
}