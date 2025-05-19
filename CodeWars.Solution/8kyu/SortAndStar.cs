namespace CodeWars.Solution._8kyu;

// Sort and Star
// https://www.codewars.com/kata/57cfdf34902f6ba3d300001e
public class SortAndStar
{
    public class Kata
    {
        public static string TwoSort(string[] s)
        {
            string[] sorted = s.OrderBy(str => str, StringComparer.Ordinal).ToArray();
            
            return string.Join("***", sorted[0].ToCharArray());
        }  
    }
}