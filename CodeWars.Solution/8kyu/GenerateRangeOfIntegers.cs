namespace CodeWars.Solution._8kyu;

// Generate range of integers
// https://www.codewars.com/kata/55eca815d0d20962e1000106
public class GenerateRangeOfIntegers
{
    public class Kata
    {
        public static int[] GenerateRange(int min, int max, int step)
        {
            List<int> range = new();

            for (int counter = min; counter <= max; counter += step)
            {
                range.Add(min);
            }
            
            return range.ToArray();
        }
    }
}