namespace CodeWars.Solution._8kyu;

// L1: Bartender, drinks!
// https://www.codewars.com/kata/568dc014440f03b13900001d
public class L1BartenderDrinks
{
    public class Kata
    {
        private const string DefaultDrink = "Beer";
        
        private static readonly Dictionary<string, string> JobDrinkMapper = new()
        {
            { "jabroni", "Patron Tequila" },
            { "school counselor", "Anything with Alcohol" },
            { "programmer", "Hipster Craft Beer" },
            { "bike gang member", "Moonshine" },
            { "politician", "Your tax dollars" },
            { "rapper", "Cristal" }
        };

        public static string GetDrinkByProfession(string p) => JobDrinkMapper.GetValueOrDefault(p.ToLower(), DefaultDrink);
    }
}