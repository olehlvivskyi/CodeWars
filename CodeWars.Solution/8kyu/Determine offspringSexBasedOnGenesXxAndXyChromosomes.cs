namespace CodeWars.Solution._8kyu;

// Determine offspring sex based on genes XX and XY chromosomes
// https://www.codewars.com/kata/56530b444e831334c0000020
public class Determine_offspringSexBasedOnGenesXxAndXyChromosomes
{
    public class Kata
    {
        public static string ChromosomeCheck(string sperm)
        {
            return sperm == "XX"
                ? "Congratulations! You're going to have a daughter."
                : "Congratulations! You're going to have a son.";
        }
    }
}