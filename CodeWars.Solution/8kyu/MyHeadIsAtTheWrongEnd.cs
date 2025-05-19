namespace CodeWars.Solution._8kyu;

// My head is at the wrong end!
// https://www.codewars.com/kata/56f699cd9400f5b7d8000b55
public class MyHeadIsAtTheWrongEnd
{
    public class Kata
    {
        public static string[] FixTheMeerkat(string[] arr)
        {
            return arr
                .Reverse()
                .ToArray();
        }
    }
}