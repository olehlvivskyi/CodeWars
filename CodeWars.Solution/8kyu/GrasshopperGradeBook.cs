namespace CodeWars.Solution._8kyu;

// Grasshopper - Grade book
// https://www.codewars.com/kata/55cbd4ba903825f7970000f5
public class GrasshopperGradeBook
{
    public class Kata
    {
        public static char GetGrade(int s1, int s2, int s3)
        {
            int average = (s1 + s2 + s3) / 3;
            return average switch
            {
                >= 90 and <= 100 => 'A',
                >= 80 and <= 89 => 'B',
                >= 70 and <= 79 => 'C',
                >= 60 and <= 69 => 'D',
                _ => 'F'
            };
        }
    }
}