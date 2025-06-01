namespace CodeWars.Solution._8kyu;

// Leonardo Dicaprio and Oscars
// https://www.codewars.com/kata/56d49587df52101de70011e4
public class LeonardoDicaprioAndOscars
{
    public static class Kata
    {
        public static string Leo(int oscar)
        {
            return oscar switch
            {
                > 88 => "Leo got one already!",
                88 => "Leo finally won the oscar! Leo is happy",
                86 => "Not even for Wolf of wallstreet?!",
                _ => "When will you give Leo an Oscar?"
            };
        }
    }
}