namespace CodeWars.Solution._8kyu;

// Training JS #7: if..else and ternary operator
// https://www.codewars.com/kata/57202aefe8d6c514300001fd
public class TrainingJs7IfElseAndTernaryOperator
{
    public class Kata
    {
        public static int SaleHotDogs(int n)
        {
            int result;
            
            if (n >= 10)
            {
                result = n * 90;
            }
            else if (n >= 5)
            {
                result = n * 95;
            }
            else
            {
                result = n * 100;
            }

            return result;
        }
    }
}