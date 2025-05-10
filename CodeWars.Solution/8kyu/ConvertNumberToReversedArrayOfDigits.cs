namespace CodeWars.Solution._8kyu;

// Convert number to reversed array of digits
// https://www.codewars.com/kata/5583090cbe83f4fd8c000051
public class ConvertNumberToReversedArrayOfDigits
{
    class Digitizer
    {
        public static long[] Digitize(long n)
        {
            return n
                .ToString()
                .Reverse()
                .Select(number => long.Parse(number.ToString()))
                .ToArray();
        }
    }
}