namespace CodeWars.Solution._8kyu;

// altERnaTIng cAsE <=> ALTerNAtiNG CaSe
// https://www.codewars.com/kata/56efc695740d30f963000557
public class AlternatingCaseAlternatingCase
{
    // Extension method is below.
}

public static class StringExt
{
    public static string ToAlternatingCase (this string s)
    {
        var changedText = s
            .Select(letter => char.IsLower(letter) 
                ? char.ToUpper(letter) 
                : char.ToLower(letter));
        return string.Concat(changedText);
    }
}