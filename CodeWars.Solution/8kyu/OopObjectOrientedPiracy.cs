namespace CodeWars.Solution._8kyu;

// OOP: Object Oriented Piracy
// https://www.codewars.com/kata/54fe05c4762e2e3047000add
public class OopObjectOrientedPiracy
{
    public class Ship
    {
        public int Draft;
        public int Crew;
  
        public Ship(int draft, int crew)
        {
            Draft = draft;
            Crew = crew;
        }

        public bool IsWorthIt() => Draft - Crew * 1.5 > 20;
    }
}