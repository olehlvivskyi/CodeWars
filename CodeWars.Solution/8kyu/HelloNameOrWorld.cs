namespace CodeWars.Solution._8kyu;

// Hello, Name or World!
// https://www.codewars.com/kata/57e3f79c9cb119374600046b
public class HelloNameOrWorld
{
    public static class Kata
    {
        public static string Hello(string name = "")
        {
            return string.IsNullOrEmpty(name) 
                ? $"Hello, {char.ToUpper(name[0])}{name[1..].ToLower()}!" 
                : "Hello, World!";
        }
    }
}