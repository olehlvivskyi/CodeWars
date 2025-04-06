namespace CodeWars.Solution._8kyu;

// Filtering even numbers (Bug Fixes)
// https://www.codewars.com/kata/566dc566f6ea9a14b500007b
public class FilteringEvenNumbersKata
{
    public static List<int> FilterOddNumber(List<int> listOfNumbers)
    {
        return listOfNumbers
            .Where(number => number % 2 == 1)
            .ToList();
    }
}