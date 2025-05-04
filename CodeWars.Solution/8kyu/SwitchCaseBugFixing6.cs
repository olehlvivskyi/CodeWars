namespace CodeWars.Solution._8kyu;

// Switch/Case - Bug Fixing #6
// https://www.codewars.com/kata/55c933c115a8c426ac000082
public class SwitchCaseBugFixing6
{
    public class Kata
    {
        public static double EvalObject(double value1, double value2, char operation)
        {
            return operation switch
            {
                '+' => value1 + value2,
                '-' => value1 - value2,
                '/' => value1 / value2,
                '*' => value1 * value2,
                '%' => value1 % value2,
                '^' => Math.Pow(value1, value2),
                _   => 0
            };
        }
    }
}