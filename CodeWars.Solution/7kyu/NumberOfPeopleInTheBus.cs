namespace CodeWars.Solution._7kyu;

// Number of People in the Bus
// https://www.codewars.com/kata/5648b12ce68d9daa6b000099
public class NumberOfPeopleInTheBus
{
    public class Kata
    {
        public static int Number(List<int[]> peopleListInOut) => peopleListInOut.Sum(x => x[0] - x[1]);
    }
}