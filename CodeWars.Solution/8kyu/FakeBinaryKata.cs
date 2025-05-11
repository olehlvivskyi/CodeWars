using System.Text;

namespace CodeWars.Solution._8kyu;

// Fake Binary
// https://www.codewars.com/kata/57eae65a4321032ce000002d
public class FakeBinaryKata
{
    public static string FakeBin(string x)
    {
        StringBuilder sb = new(x.Length);
        foreach (var ch in x)
        {
            sb.Append(ch < '5' 
                ? 0 
                : 1);
        }
        return sb.ToString();
    }
}