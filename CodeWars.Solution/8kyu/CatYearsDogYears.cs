namespace CodeWars.Solution._8kyu;

// Cat years, Dog years
// https://www.codewars.com/kata/5a6663e9fd56cb5ab800008b
public class CatYearsDogYears
{
    public class Dinglemouse 
    {
        public static int[] humanYearsCatYearsDogYears(int humanYears)
        {
            return humanYears switch
            {
                1 => [1, 15, 15],
                2 => [2, 24, 24],
                _ => [humanYears, 24 + (humanYears - 2) * 4, 24 + (humanYears - 2) * 5]
            };
        }
    }
}