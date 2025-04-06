namespace CodeWars.Solution._8kyu;

// Basic Mathematical Operations
// https://www.codewars.com/kata/57356c55867b9b7a60000bd7
public static class BasicMathematicalOperationsKata
{
    public static double basicOp(char operation, double value1, double value2)
    {
        return operation switch
        {
            '+' => value1 + value2,
            '-' => value1 - value2,
            '*' => value1 * value2,
            '/' => value1 / value2,
            _ => throw new ArgumentException("Invalid operation", operation.ToString())
        };
    }
}