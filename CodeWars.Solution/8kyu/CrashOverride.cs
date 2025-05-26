using System.Text.RegularExpressions;

namespace CodeWars.Solution._8kyu;

// Crash Override
// https://www.codewars.com/kata/578c1e2edaa01a9a02000b7f
public class CrashOverride
{
    public partial class Kata
    {
        public static string AliasGen(string fName, string lName)
        {
            string firstNameLetter = char.ToUpper(fName[0]).ToString();
            string lastNameLetter = char.ToUpper(lName[0]).ToString();
            
            if (!Regex.IsMatch(firstNameLetter, "[A-Za-z]") || !Regex.IsMatch(lastNameLetter, "[A-Za-z]"))
            {
                return "Your name must start with a letter from A - Z.";
            }
      
            return $"{FirstName[firstNameLetter]} {Surname[lastNameLetter]}";
        }
    }

    // This part was hidden behind Codewars and implemented to avoid errors.
    public partial class Kata
    {
        public static Dictionary<string, string> FirstName = new();
        public static Dictionary<string, string> Surname = new();
    }
}