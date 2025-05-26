namespace CodeWars.Solution._8kyu;

// Compare within margin
// https://www.codewars.com/kata/56453a12fcee9a6c4700009c
public class CompareWithinMargin
{
    public class Kata
    {
        public static int CloseCompare(double a, double b, double margin = 0)
        {
            if (Math.Abs(a - b) <= margin)
            {
                return 0;
            }
            
            return a > b 
                ? 1 
                : -1;
        }
    }
}