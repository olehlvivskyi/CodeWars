namespace CodeWars.Solution._8kyu;

// String Templates - Bug Fixing #5
// https://www.codewars.com/kata/55c90cad4b0fe31a7200001f
public class StringTemplatesBugFixing5
{
    public static class Kata 
    {
        public static string buildString(string[] args)
        {
            return string.Format("I like {0}!", String.Join(", ", args));
        }
    }
}