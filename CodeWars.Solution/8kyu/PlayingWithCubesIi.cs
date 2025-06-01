namespace CodeWars.Solution._8kyu;

// Playing with cubes II
// https://www.codewars.com/kata/55c0ac142326fdf18d0000af
public class PlayingWithCubesIi
{
    public class Cube(int side = 0)
    {
        private int _side = Math.Abs(side);

        public int GetSide()
        {
            return _side;
        }
  
        public void SetSide(int side)
        {
            _side = Math.Abs(side);
        }
    }
}