namespace CodeWars.Solution._8kyu;

// Is it a number?
// https://www.codewars.com/kata/57126304cdbf63c6770012bd
public class IsItANumber
{
    public class CodeWars
    {
        public static bool IsDigit(string s) => float.TryParse(s, out _);
    }
}