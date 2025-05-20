namespace CodeWars.Solution._8kyu;

// Well of Ideas - Easy Version
// https://www.codewars.com/kata/57f222ce69e09c3630000212
public class WellOfIdeasEasyVersion
{
    public class Kata
    {
        public static string Well(string[] x)
        {
            return x.Count(idea => idea == "good") switch
            {
                > 2 => "I smell a series!",
                >= 1 => "Publish!",
                _ => "Fail!"
            };
        }
    }
}