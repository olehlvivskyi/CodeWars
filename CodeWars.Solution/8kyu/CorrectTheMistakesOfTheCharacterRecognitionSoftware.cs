namespace CodeWars.Solution._8kyu;

// Correct the mistakes of the character recognition software
// https://www.codewars.com/kata/577bd026df78c19bca0002c0
public class CorrectTheMistakesOfTheCharacterRecognitionSoftware
{
    public class Kata
    {
        public static string Correct(string text)
        {
            return text
                .Replace('5', 'S')
                .Replace('0', 'O')
                .Replace('1', 'I');
        }
    }
}