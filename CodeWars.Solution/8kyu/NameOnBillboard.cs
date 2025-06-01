namespace CodeWars.Solution._8kyu;

// Name on billboard
// https://www.codewars.com/kata/570e8ec4127ad143660001fd
public class NameOnBillboard
{
    public class Kata 
    {
        // Here "*" cannot be used by Kata's description.
        public static double Billboard(string name, double price = 30) => name.Sum(_ => price);
    }
}