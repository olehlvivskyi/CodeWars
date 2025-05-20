namespace CodeWars.Solution._8kyu;

// Multiplication table for number
// https://www.codewars.com/kata/5a2fd38b55519ed98f0000ce
public class MultiplicationTableForNumber
{
    public static class Kata
    {
        public static string MultiTable(int number)
        {
            IEnumerable<string> result = Enumerable
                .Range(1, 10)
                .Select(n => $"{n} * {number} = {n * number}");
            
            return string.Join("\n", result);
        }
    }
}