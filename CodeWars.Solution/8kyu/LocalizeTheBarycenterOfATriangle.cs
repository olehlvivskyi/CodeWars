namespace CodeWars.Solution._8kyu;

// Localize The Barycenter of a Triangle
// https://www.codewars.com/kata/5601c5f6ba804403c7000004
public class LocalizeTheBarycenterOfATriangle
{
    public class Barycenter
    {
        public static double[] BarTriang(double[] x, double[] y, double[] z)
        {
            double x0 = Math.Round((x[0] + y[0] + z[0]) / 3, 4);
            double y0 = Math.Round((x[1] + y[1] + z[1]) / 3, 4);
            return [x0, y0];
        }   
    }
}