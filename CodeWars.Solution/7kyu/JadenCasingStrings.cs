namespace CodeWars.Solution._7kyu;

// Jaden Casing Strings
// https://www.codewars.com/kata/5390bac347d09b7da40006f6
public class JadenCasingStrings;

// Note: the clever way I saw after submission was: CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
public static class JadenCase
{
    public static string ToJadenCase(this string phrase)
    {
        return string.Join(" ", phrase
            .Split(' ')
            .Select(word => char.ToUpper(word[0]) + word[1..]));
    }
}