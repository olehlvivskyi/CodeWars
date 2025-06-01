namespace CodeWars.Solution._8kyu;

// Pirates!! Are the Cannons ready!??
// https://www.codewars.com/kata/5748a883eb737cab000022a6
public class PiratesAreTheCannonsReady
{
    public static class Kata
    {
        public static string CannonsReady(Dictionary<string, string> gunners)
        {
            return gunners.ContainsValue("nay") 
                ? "Shiver me timbers!"
                : "Fire!";
        }
    }
}