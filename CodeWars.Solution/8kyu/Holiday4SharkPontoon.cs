namespace CodeWars.Solution._8kyu;

// Holiday VI - Shark Pontoon
// https://www.codewars.com/kata/57e921d8b36340f1fd000059
public class Holiday4SharkPontoon
{
    public class Kata
    {
        public static string Shark(
            int pontoonDistance, 
            int sharkDistance, 
            int youSpeed, 
            int sharkSpeed, 
            bool dolphin)
        {
            double sharkTime = sharkDistance / (dolphin ? sharkSpeed * 0.5 : sharkSpeed);
            double youTime = (double) pontoonDistance / youSpeed;
            
            return youTime < sharkTime 
                ? "Alive!" 
                : "Shark Bait!";
        }
    }
}