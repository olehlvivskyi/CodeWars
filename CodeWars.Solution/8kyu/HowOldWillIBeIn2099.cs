namespace CodeWars.Solution._8kyu;

// How old will I be in 2099?
// https://www.codewars.com/kata/5761a717780f8950ce001473
public class HowOldWillIBeIn2099
{
    public static class AgeDiff 
    {
        public static string CalculateAge(int birth, int yearTo) 
        {
            int ageDifference = yearTo - birth;
            string yearOrYears = Math.Abs(ageDifference) == 1 
                ? "year" 
                : "years";
            
            return ageDifference switch
            {
                > 0 => $"You are {ageDifference} {yearOrYears} old.",
                < 0 => $"You will be born in {Math.Abs(ageDifference)} {yearOrYears}.",
                _   => "You were born this very year!"
            };
        }
    }
}