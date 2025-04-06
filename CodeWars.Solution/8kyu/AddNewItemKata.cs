namespace CodeWars.Solution._8kyu;

// Add new item (collections are passed by reference)
// https://www.codewars.com/kata/566dc05f855b36a031000048
public class AddNewItemKata
{
    public static List<int> AddExtra(List<int> listOfNumbers) => [..listOfNumbers, 3];
}