namespace CodeWars.Solution._8kyu;

// UEFA EURO 2016
// https://www.codewars.com/kata/57613fb1033d766171000d60
public class UefaEuro2016
{
    public class Kata
    {
        public static string UefaEuro2016(string[] teams, int[] scores)
        {
            return scores[0] == scores[1]
                ? $"At match {teams[0]} - {teams[1]}, teams played draw."
                : $"At match {teams[0]} - {teams[1]}, {(scores[0] > scores[1] ? teams[0] : teams[1])} won!";
        }
    }
}