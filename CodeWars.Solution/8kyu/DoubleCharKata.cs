using System.Text;

namespace CodeWars.Solution._8kyu;

// Double Char
// https://www.codewars.com/kata/56b1f01c247c01db92000076
public class DoubleCharKata
{
    public static string DoubleChar(string s)
    {
        StringBuilder sb = new(s.Length * 2);
        foreach (var ch in s)
        {
            sb.Append(ch);
            sb.Append(ch);
        }
        return sb.ToString();
    }
}