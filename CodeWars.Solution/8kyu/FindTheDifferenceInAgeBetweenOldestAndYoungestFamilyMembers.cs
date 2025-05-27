namespace CodeWars.Solution._8kyu;

// Find the Difference in Age between Oldest and Youngest Family Members
// https://www.codewars.com/kata/5720a1cb65a504fdff0003e2
public class FindTheDifferenceInAgeBetweenOldestAndYoungestFamilyMembers
{
    public class Kata
    {
        public static int[] DifferenceInAges(int[] ages) => [ages.Min(), ages.Max(), ages.Max() - ages.Min()];
    }
}