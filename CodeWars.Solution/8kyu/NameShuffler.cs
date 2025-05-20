namespace CodeWars.Solution._8kyu;

// Name Shuffler
// https://www.codewars.com/kata/559ac78160f0be07c200005a
public class NameShuffler
{
    public class Kata
    {
        public static string NameShuffler(string str)
        {
            var reversedName = str
                .Split(' ')
                .Reverse();
            
            return string.Join(' ', reversedName);
        }
    }
}