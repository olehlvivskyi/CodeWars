namespace CodeWars.Solution._8kyu;

// Evil or Odious
// https://www.codewars.com/kata/56fcfad9c7e1fa2472000034
public class EvilOrOdious
{
    public class Kata
    {
        public static string Evil(int n)
        {
            int numbersOf1 = n
                .ToString("B")
                .Count(digit => digit == '1');

            return numbersOf1 % 2 == 0
                ? "It's Evil!"
                : "It's Odious!";
        }
    }
}