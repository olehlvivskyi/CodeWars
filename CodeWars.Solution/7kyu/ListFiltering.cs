namespace CodeWars.Solution._7kyu;

// List Filtering
// https://www.codewars.com/kata/53dbd5315a3c69eed20002dd
public class ListFiltering
{
    public class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems) => listOfItems.OfType<int>();
    }
}