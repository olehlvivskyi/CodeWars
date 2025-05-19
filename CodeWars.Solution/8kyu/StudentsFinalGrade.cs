namespace CodeWars.Solution._8kyu;

// Student's Final Grade
// https://www.codewars.com/kata/5ad0d8356165e63c140014d4
public class StudentsFinalGrade
{
    public class Kata
    {
        public static int FinalGrade(int exam, int projects)
        {
            return (exam, projects) switch
            {
                (> 90, _) => 100,
                (_, > 10) => 100,
                (> 75, >= 5) => 90,
                (> 50, >= 2) => 75,
                _ => 0,
            };
        }
    }
}