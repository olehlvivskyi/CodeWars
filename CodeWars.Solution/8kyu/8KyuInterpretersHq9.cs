using System.Text;

namespace CodeWars.Solution._8kyu;

// 8kyu interpreters: HQ9+
// https://www.codewars.com/kata/591588d49f4056e13f000001
public class EightKyuInterpretersHq9 
{
    public class HQ9
    {
        public static string? Interpret(string code)
        {
            return code switch
            {
                "H" => "Hello World!",
                "Q" => code,
                "9" => GetNinetyNineBottlesOfBeerLyrics(),
                _ => null
            };
        }

        private static string GetNinetyNineBottlesOfBeerLyrics()
        {
            StringBuilder stringBuilder = new();
            
            for (int bottles = 99; bottles >= 2; bottles--)
            {
                string nextBottle = bottles - 1 == 1 ? "bottle" : "bottles";
                stringBuilder.AppendLine($"{bottles} bottles of beer on the wall, {bottles} bottles of beer.");
                stringBuilder.AppendLine($"Take one down and pass it around, {bottles - 1} {nextBottle} of beer on the wall.");
            }
            stringBuilder.AppendLine("1 bottle of beer on the wall, 1 bottle of beer.");
            stringBuilder.AppendLine("Take one down and pass it around, no more bottles of beer on the wall.");
            stringBuilder.AppendLine("No more bottles of beer on the wall, no more bottles of beer.");
            stringBuilder.Append("Go to the store and buy some more, 99 bottles of beer on the wall.");
            
            return stringBuilder.ToString();
        }
    }
}