namespace CodeWars.Solution._8kyu;

// Convert to Binary
// https://www.codewars.com/kata/59fca81a5712f9fa4700159a/train/csharp
public class ConvertToBinary
{
    public static class Kata
    {
        public static int ToBinary(int n) => int.Parse(Convert.ToString(n, 2));
    }
}