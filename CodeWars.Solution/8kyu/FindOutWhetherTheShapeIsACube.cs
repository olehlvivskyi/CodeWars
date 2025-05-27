namespace CodeWars.Solution._8kyu;

// Find out whether the shape is a cube
// https://www.codewars.com/kata/58d248c7012397a81800005c
public class FindOutWhetherTheShapeIsACube
{
    public class CubeChecker
    {
        public bool IsCube(double volume, double side)
        {
            return volume > 0 && side > 0 && volume == Math.Pow(side, 3);
        }
    }
}