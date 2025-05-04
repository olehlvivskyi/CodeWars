namespace CodeWars.Solution._8kyu;

// Take an Arrow to the knee, Functionally
// https://www.codewars.com/kata/559f3123e66a7204f000009f
public class TakeAnArrowToTheKneeFunctionally
{
    public class Kata
    {
        public static string ArrowFunc(int[] arr)
        {
            var arrayOfChars = arr
                .Select(Tools.FromCharCode)
                .ToArray();
            return string.Join("", arrayOfChars);
        }
    }
    
    // This class is made to avoid error caused by missing implementation.
    static class Tools
    {
        public static object FromCharCode(int number)
        {
            throw new NotImplementedException();
        }
    }
}