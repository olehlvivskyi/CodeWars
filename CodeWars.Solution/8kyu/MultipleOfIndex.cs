namespace CodeWars.Solution._8kyu;

// Multiple of index
// https://www.codewars.com/kata/5a34b80155519e1a00000009
public class MultipleOfIndex
{
    public static class Kata
    {
        public static List<int> MultipleOfIndex(List<int> xs)
        {
            return xs
                .Where((number, index) => number != 0 && index != 0
                    ? number % index == 0
                    : number == 0)
                .ToList();
        }
    }
}