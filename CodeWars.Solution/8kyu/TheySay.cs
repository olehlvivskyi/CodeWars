namespace CodeWars.Solution._8kyu;

// They say that only the name is long enough to attract attention. They also said that only a simple Kata will have someone to solve it. This is a sadly story #1: Are they opposite?
// https://www.codewars.com/kata/574b1916a3ebd6e4fa0012e7
public class TheySay
{
    public class Kata
    {
        public static bool IsOpposite(string s1, string s2)
        {
            if (s1.Length != s2.Length || string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2))
            {
                return false;
            }
            
            return s1.SequenceEqual(s2
                .Select(c => char.IsUpper(c) 
                    ? char.ToLower(c) 
                    : char.ToUpper(c)));
        }
    }
}