using System.Text;

namespace CodeWars.Solution._8kyu;

// Triple Trouble
// https://www.codewars.com/kata/5704aea738428f4d30000914
public class TripleTrouble
{
    public class Kata
    {
        public static string TripleTrouble(string one, string two, string three)
        {
            StringBuilder stringBuilder = new();
            for (int index = 0; index < one.Length; index++)
            {
                stringBuilder.Append(one[index]);
                stringBuilder.Append(two[index]);
                stringBuilder.Append(three[index]);
            }
            
            return stringBuilder.ToString();
        }
    }
}