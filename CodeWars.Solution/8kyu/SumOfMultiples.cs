namespace CodeWars.Solution._8kyu;

// Sum of Multiples
// https://www.codewars.com/kata/57241e0f440cd279b5000829
public class SumOfMultiples
{
    public class Kata
    {
        public static int SumMul(int n, int m)
        {
            if (m < n || n <= 0)
            {
                throw new ArgumentException();
            }
            
            List<int> numbers = new();
            
            for (int i = n; i < m; i += n)
            {
                numbers.Add(i);
            }
            
            return numbers.Sum();
        }
    }
}