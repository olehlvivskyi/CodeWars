namespace CodeWars.Solution._8kyu;

// Printing Array elements with Comma delimiters
// https://www.codewars.com/kata/56e2f59fb2ed128081001328
public class PrintingArrayElementsWithCommaDelimiters
{
    public class Kata
    {
        public static string PrintArray(object[] array)
        {
            var arrayString = array
                .Select(item => item.GetType().IsArray
                    ? string.Join(",", (object[])item)
                    : item);
            
            return string.Join(",", arrayString);
        }
    }
}