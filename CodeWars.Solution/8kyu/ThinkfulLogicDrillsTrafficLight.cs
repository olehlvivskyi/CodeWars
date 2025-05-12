namespace CodeWars.Solution._8kyu;

// Thinkful - Logic Drills: Traffic light
// https://www.codewars.com/kata/58649884a1659ed6cb000072
public class ThinkfulLogicDrillsTrafficLight
{
    public class Kata
    {
        public static string UpdateLight(string current)
        {
            return current switch
            {
                "green"  => "yellow",
                "yellow" => "red",
                "red"    => "green",
                _        => throw new ArgumentOutOfRangeException(nameof(current))
            };
        }
    }
}