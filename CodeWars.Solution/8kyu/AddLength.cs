namespace CodeWars.Solution._8kyu;

// Add Length
// https://www.codewars.com/kata/559d2284b5bb6799e9000047
public class AddLength
{
    public class Kata
    {
        public static string[] AddLength(string str)
        {
            return str
                .Split(' ')
                .Select(word => $"{word} {word.Length}")
                .ToArray();
        }
    }
}