namespace CodeWars.Solution._8kyu;

// Quadrants
// https://www.codewars.com/kata/643af0fa9fa6c406b47c5399
public class Quadrants
{
    public static class Kata
    {
        public static int Quadrant(int x, int y)
        {
            return (x, y) switch
            {
                (> 0, > 0) => 1,
                (< 0, > 0) => 2,
                (< 0, < 0) => 3,
                (> 0, < 0) => 4,
                _              => 0
            };
        }
    }
}