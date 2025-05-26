namespace CodeWars.Solution._8kyu;

// Define a card suit
// https://www.codewars.com/kata/5a360620f28b82a711000047
public class DefineACardSuit
{
    public partial class Kata
    {
        public static string DefineSuit(string card)
        {
            return card[^1] switch
            {
                '\u2663' => "clubs",
                '\u2666' => "diamonds",
                '\u2665' => "hearts",
                '\u2660' => "spades",
                _ => throw new Exception("Invalid card")
            };
        }
    }
}