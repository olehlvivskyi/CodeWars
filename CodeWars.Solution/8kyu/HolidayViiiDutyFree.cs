namespace CodeWars.Solution._8kyu;

// Holiday VIII - Duty Free
// https://www.codewars.com/kata/57e92e91b63b6cbac20001e5
public class HolidayViiiDutyFree
{
    public class Kata
    {
        public static int DutyFree(int normPrice, int Discount, int hol) => (int) (hol / (normPrice / 100f * Discount ));
    }
}