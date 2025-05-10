namespace CodeWars.Solution._8kyu;

// Remove String Spaces
// https://www.codewars.com/kata/57eae20f5500ad98e50002c5
public class RemoveStringSpaces
{
    public static class SpacesRemover
    {
        public static string NoSpace(string input) => input.Replace(" ", string.Empty);
    }
}