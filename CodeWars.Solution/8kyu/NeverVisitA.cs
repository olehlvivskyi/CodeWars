namespace CodeWars.Solution._8kyu;

// Never visit a . . . !?
// https://www.codewars.com/kata/56c5847f27be2c3db20009c3
public class NeverVisitA
{
    public class Kata
    {
        private static readonly string[] Fruits =
        [
            "not-used", "kiwi", "pear", "kiwi", "banana", "melon", "banana", "melon", "pineapple", "apple",
            "pineapple", "cucumber", "pineapple", "cucumber", "orange", "grape", "orange", "grape", "apple", "grape",
            "cherry", "pear", "cherry", "pear", "kiwi", "banana", "kiwi", "apple", "melon", "banana", "melon",
            "pineapple", "melon", "pineapple", "cucumber", "orange", "apple", "orange", "grape", "orange", "grape",
            "cherry", "pear", "cherry", "pear", "apple", "pear", "kiwi", "banana", "kiwi", "banana", "melon",
            "pineapple", "melon", "apple", "cucumber", "pineapple", "cucumber", "orange", "cucumber", "orange",
            "grape", "cherry", "apple", "cherry", "pear", "cherry", "pear", "kiwi", "pear", "kiwi", "banana",
            "apple", "banana", "melon", "pineapple", "melon", "pineapple", "cucumber", "pineapple", "cucumber",
            "apple", "grape", "orange", "grape", "cherry", "grape", "cherry", "pear", "cherry", "apple", "kiwi",
            "banana", "kiwi", "banana", "melon", "banana", "melon", "pineapple", "apple", "pineapple"
        ];
        
        // This method will return always "apple" value
        public static string SubtractSum(int number)
        {
            do
            {
                int digitSum = number.ToString().Sum(digit => int.Parse(digit.ToString()));
                number -= digitSum;
            } while (number > 100);
            
            return Fruits[number];
        }
    }
}