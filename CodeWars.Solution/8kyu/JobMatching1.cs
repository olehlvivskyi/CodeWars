namespace CodeWars.Solution._8kyu;

// Job Matching #1
// https://www.codewars.com/kata/56c22c5ae8b139416c00175d
public abstract class JobMatching1
{
    public class Strive
    {
        public static bool Match(Candidate candidate, Job job)
        {
            if (candidate.MinSalary == null || job.MaxSalary == null)
            {
                throw new ArgumentException();
            }

            return candidate.MinSalary * 0.9 <= job.MaxSalary;
        }
    }
    
    // This class is made to avoid error caused by missing implementation.
    public abstract class Job
    {
        public double? MaxSalary { get; set; }
    }

    // This class is made to avoid error caused by missing implementation.
    public abstract class Candidate
    {
        public double? MinSalary { get; set; }
    }
}