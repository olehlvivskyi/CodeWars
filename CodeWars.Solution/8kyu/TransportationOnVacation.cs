namespace CodeWars.Solution._8kyu;

// Transportation on vacation
// https://www.codewars.com/kata/568d0dd208ee69389d000016
public class TransportationOnVacation
{
    public class RentalCar {
    
        public static int RentalCarCost(int d)
        {
            return d switch
            {
                >= 7 => d * 40 - 50,
                >= 3 => d * 40 - 20,
                _    => d * 40
            };
        }
    }
}