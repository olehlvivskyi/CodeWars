namespace CodeWars.Solution._8kyu;

// To square(root) or not to square(root)
// https://www.codewars.com/kata/57f6ad55cca6e045d2000627
public class ToSquareRootOrNotToSquareRoot
{
    public class Kata
    {
        public static int[] SquareOrSquareRoot(int[] array)
        {
            return array
                .Select(number => Math.Sqrt(number) % 1 == 0 
                    ? (int) Math.Sqrt(number) 
                    : number * number)
                .ToArray();
        }
    }
}