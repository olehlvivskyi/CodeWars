namespace CodeWars.Solution._8kyu;

// Collatz Conjecture (3n+1)
// https://www.codewars.com/kata/577a6e90d48e51c55e000217
public class CollatzConjecture3n1
{
    public class Kata
    {
        public static uint Hotpo(uint n)
        {
            uint counter = 0;
            while (n != 1)
            {
                counter++;
                n = n % 2 == 0
                    ? n / 2
                    : 3 * n + 1;
            }
            return counter;
        }
    }
}