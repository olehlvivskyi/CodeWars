namespace CodeWars.Solution._8kyu;

// Filter out the geese
// https://www.codewars.com/kata/57ee4a67108d3fd9eb0000e7
public class FilterOutTheGeese
{
    public static class Filter
    {
        public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
        {
            return birds
                .Except(["African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher"]);
        }
    }
}