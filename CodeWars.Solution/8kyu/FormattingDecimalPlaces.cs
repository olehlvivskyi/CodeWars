namespace CodeWars.Solution._8kyu;

// Formatting decimal places #0
// https://www.codewars.com/kata/5641a03210e973055a00000d
public class FormattingDecimalPlaces
{
    public class Numbers
    {
        public static double TwoDecimalPlaces(double number) => double.Round(number, 2);
    }
}