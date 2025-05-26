namespace CodeWars.Solution._8kyu;

// Did she say hallo?
// https://www.codewars.com/kata/56a4addbfd4a55694100001f
public class DidSheSayHallo
{
    public class Kata
    {
        private static readonly string[] Greetings = { "hello", "ciao", "salut", "hallo", "hola", "ahoj", "czesc" };
        
        public static bool Validate_hello(string greetings) => Greetings.Any(greeting => greetings.Contains(greeting, StringComparison.OrdinalIgnoreCase));
    }
}