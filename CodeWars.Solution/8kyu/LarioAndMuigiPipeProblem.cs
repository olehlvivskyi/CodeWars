namespace CodeWars.Solution._8kyu;

// Lario and Muigi Pipe Problem
// https://www.codewars.com/kata/56b29582461215098d00000f
public class LarioAndMuigiPipeProblem
{
    public class Fixer
    {
        public static List<int> PipeFix(List<int> numbers)
        {
            return Enumerable
                .Range(numbers[0], numbers[^1] - numbers[0] + 1)
                .ToList();
        }
    }
}