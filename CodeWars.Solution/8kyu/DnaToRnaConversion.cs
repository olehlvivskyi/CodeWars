namespace CodeWars.Solution._8kyu;

// DNA to RNA Conversion
// https://www.codewars.com/kata/5556282156230d0e5e000089
public class DnaToRnaConversion
{
    public class Converter
    {
        public string dnaToRna(string dna) => dna.Replace("T", "U");
    }
}