namespace CodeWars.Solution._8kyu;

// Hex to Decimal
// https://www.codewars.com/kata/57a4d500e298a7952100035d
public class HexToDecimal
{
    public class Kata
    {
        public static int HexToDec(string hexString)
        {
            return hexString[0] != '-'
                ? Convert.ToInt32(hexString, 16) 
                : -Convert.ToInt32(hexString[1..], 16);
        }
    }
}