namespace CodeWars.Solution._8kyu;

// Welcome!
// https://www.codewars.com/kata/577ff15ad648a14b780000e7
public class Welcome
{
    public static class Kata
    {
        private const string DefaultLanguage = "english";
        
        private static readonly Dictionary<string, string> Greetings = new()
        {
            { "english", "Welcome" },
            { "czech", "Vitejte" },
            { "danish", "Velkomst" },
            { "dutch", "Welkom" },
            { "estonian", "Tere tulemast" },
            { "finnish", "Tervetuloa" },
            { "flemish", "Welgekomen" },
            { "french", "Bienvenue" },
            { "german", "Willkommen" },
            { "irish", "Failte" },
            { "italian", "Benvenuto" },
            { "latvian", "Gaidits" },
            { "lithuanian", "Laukiamas" },
            { "polish", "Witamy" },
            { "spanish", "Bienvenido" },
            { "swedish", "Valkommen" },
            { "welsh", "Croeso" }
        };
        
        public static string Greet(string language)
        {
            return Greetings[Greetings.ContainsKey(language)
                ? language
                : DefaultLanguage];
        }
    }
}