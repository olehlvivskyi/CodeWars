namespace CodeWars.Solution._8kyu;

// Total amount of points
// https://www.codewars.com/kata/5bb904724c47249b10000131
public class TotalAmountOfPoints
{
    public static class Kata 
    {
        public static int TotalPoints(string[] games)
        {
            return games
                .Sum(game => game[0] > game[2] 
                    ? 3 
                    : game[0] == game[2] 
                        ? 1 
                        : 0);
        }
    }
}