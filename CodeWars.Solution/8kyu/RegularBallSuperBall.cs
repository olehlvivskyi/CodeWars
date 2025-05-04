namespace CodeWars.Solution._8kyu;

// Regular Ball Super Ball
// https://www.codewars.com/kata/53f0f358b9cb376eca001079
public class RegularBallSuperBall
{
    public class Ball(string ballType)
    {
        public string ballType { get; set; } = ballType;

        public Ball() : this("regular")
        {
        }
    }
}