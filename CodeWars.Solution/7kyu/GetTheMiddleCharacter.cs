namespace CodeWars.Solution._7kyu;

// Get the Middle Character
// https://www.codewars.com/kata/56747fd5cb988479af000028
public class GetTheMiddleCharacter
{
    public class Kata
    {
        public static string GetMiddle(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                throw new ArgumentException();
            }
            
            return s.Length % 2 == 1
                ? s[s.Length / 2].ToString()
                : s[(s.Length / 2 - 1)..(s.Length / 2 + 1)];
        }
    }
}