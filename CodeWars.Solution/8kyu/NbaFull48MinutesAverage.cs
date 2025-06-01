namespace CodeWars.Solution._8kyu;

// NBA full 48 minutes average
// https://www.codewars.com/kata/587c2d08bb65b5e8040004fd
public class NbaFull48MinutesAverage
{
    public class Kata
    {
        public static double NbaExtrap(double ppg, double mpg)
        {
            return ppg == 0 || mpg == 0 
                ? 0
                : double.Round(ppg * (48 / mpg), 1);
        }
    }
}