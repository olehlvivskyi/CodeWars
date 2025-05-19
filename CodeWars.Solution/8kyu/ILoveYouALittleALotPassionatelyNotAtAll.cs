namespace CodeWars.Solution._8kyu;

// I love you, a little , a lot, passionately ... not at all
// https://www.codewars.com/kata/57f24e6a18e9fad8eb000296
public class ILoveYouALittleALotPassionatelyNotAtAll
{
    public class Kata
    {
        public static string HowMuchILoveYou(int nb_petals)
        {
            return (nb_petals % 6) switch
            {
                1 => "I love you",
                2 => "a little",
                3 => "a lot",
                4 => "passionately",
                5 => "madly",
                _ => "not at all"
            };
        }
    }
}