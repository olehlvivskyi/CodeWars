namespace CodeWars.Solution._8kyu;

// Finish Guess the Number Game
// https://www.codewars.com/kata/568018a64f35f0c613000054
public class FinishGuessTheNumberGameKata
{
    public class Guesser
    {
        private int number;
        private int lives;

        public Guesser(int number, int lives)
        {
            this.number = number;
            this.lives = lives;
        }

        public bool Guess(int n)
        {
            if (lives == 0)
            {
                throw new Exception("You have no lives left");
            }

            if (n == number)
            {
                return true;
            }

            lives--;
            return false;
        }
    }
}