namespace CodeWars.Solution._8kyu;

// Grader
// https://www.codewars.com/kata/53d16bd82578b1fb5b00128c
public class Grader
{
    public class Kata
    {
        public static char Grader(double score)
        {
            return score switch
            {
                >= 0.9 and <= 1 => 'A',
                >= 0.8 and < 0.9 => 'B',
                >= 0.7 and < 0.8 => 'C',
                >= 0.6 and < 0.7 => 'D',
                _ => 'F'
            };
        }
    }
}