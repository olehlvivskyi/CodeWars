namespace CodeWars.Solution._8kyu;

// Logical calculator
// https://www.codewars.com/kata/57096af70dad013aa200007b
public class LogicalCalculator
{
    public class Kata
    {
        public static bool LogicalCalc(bool[] array, string op)
        {
            return op switch
            {
                "AND" => array.All(x => x),
                "OR" => array.Any(x => x),
                "XOR" => array.Aggregate((previous, next) => previous ^ next),
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}