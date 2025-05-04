namespace CodeWars.Solution._8kyu;

// Rock Paper Scissors!
// https://www.codewars.com/kata/5672a98bdbdd995fad00000f
public class RockPaperScissors
{
    public class Kata
    {
        const string Rock = "rock";
        const string Paper = "paper";
        const string Scissors = "scissors";
        
        public string Rps(string p1, string p2)
        {
            return (p1, p2) switch
            {
                (Rock, Scissors) or (Scissors, Paper) or (Paper, Rock) => "Player 1 won!",
                (Scissors, Rock) or (Paper, Scissors) or (Rock, Paper) => "Player 2 won!",
                _ => "Draw!"
            };
        }
    }
}