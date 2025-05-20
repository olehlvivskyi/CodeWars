namespace CodeWars.Solution._8kyu;

// Price of Mangoes
// https://www.codewars.com/kata/57a77726bb9944d000000b06
public class PriceOfMangoes
{
    public class Kata
    {
        public static int Mango(int quantity, int price) => (quantity - quantity / 3) * price;
    }
}