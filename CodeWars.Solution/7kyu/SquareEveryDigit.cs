namespace CodeWars.Solution._7kyu;

// Square Every Digit
// https://www.codewars.com/kata/546e2562b03326a88e000020
public class SquareEveryDigit
{
    public class Kata
    {
        public static int SquareDigits(int n)
        {
            string result = string.Concat(n
                .ToString()
                .Select(digit => (int) Math.Pow(char.GetNumericValue(digit), 2)));
            
            return int.Parse(result);
        }
    }
}