namespace CodeWars.Solution._8kyu;

// Abbreviate a Two Word Name
// https://www.codewars.com/kata/57eadb7ecd143f4c9c0000a3
public class AbbreviateATwoWordName
{
    public class Kata
    {
        public static string AbbrevName(string name)
        {
            var nameAndSurname = name.Split(' ');
            return $"{nameAndSurname[0][0]}.{nameAndSurname[1][0]}".ToUpper();
        }
    }
}