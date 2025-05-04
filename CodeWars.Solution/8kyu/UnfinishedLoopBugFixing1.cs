namespace CodeWars.Solution._8kyu;

// Unfinished Loop - Bug Fixing #1
// https://www.codewars.com/kata/55c28f7304e3eaebef0000da
public class UnfinishedLoopBugFixing1
{
    public class Kata
    {
        public static List<int> CreateList(int number)
        {
            List<int> list = new List<int>();
    
            for(int counter = 1; counter <= number; counter++)
            {
                list.Add(counter);
            }
    
            return list;
        }
    }
}