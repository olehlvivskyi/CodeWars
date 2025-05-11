namespace CodeWars.Solution._8kyu;

// Calculate BMI
// https://www.codewars.com/kata/57a429e253ba3381850000fb
public class CalculateBmi
{
    public class Kata
    {
        public static string Bmi(double weight, double height)
        {
            double bmi = weight / (height * height);
            return bmi switch
            {
                <= 18.5 => "Underweight",
                <= 25.0 => "Normal",
                <= 30.0 => "Overweight",
                _ => "Obese"
            };
        }
    }
}