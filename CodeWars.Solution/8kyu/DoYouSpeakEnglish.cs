namespace CodeWars.Solution._8kyu;

// Do you speak "English"?
// https://www.codewars.com/kata/58dbdccee5ee8fa2f9000058
public class DoYouSpeakEnglish
{
    static class Kata
    {
        public static bool SpeakEnglish(string sentence) => sentence.Contains("english", StringComparison.OrdinalIgnoreCase);
    }
}