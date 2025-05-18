namespace CodeWars.Solution._8kyu;

// Reversed Words
// https://www.codewars.com/kata/51c8991dee245d7ddf00000e
public class ReversedWords
{
    public class Kata
    {
        public static string ReverseWords(string str)
        {
            return string.Join(" ", str
                .Split()
                .Reverse());
        }
    }
}