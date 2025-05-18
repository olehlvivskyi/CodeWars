namespace CodeWars.Solution._8kyu;

// Is the string uppercase
// https://www.codewars.com/kata/56cd44e1aa4ac7879200010b
public class IsTheStringUppercase
{
    // Extension method is below
}

public static class StringExtensions
{
    public static bool IsUpperCase(this string text) => !text.Any(char.IsLower);
}