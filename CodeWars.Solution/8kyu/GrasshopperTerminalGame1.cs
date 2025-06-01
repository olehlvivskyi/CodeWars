namespace CodeWars.Solution._8kyu;

// Grasshopper - Terminal Game #1
// https://www.codewars.com/kata/55e8aba23d399a59500000ce
public class GrasshopperTerminalGame1
{
    public class Hero(string name = "Hero")
    {
        public string Name { get; init; } = name;
        public string Position { get; } = "00";
        public float Health { get; } = 100;
        public float Damage { get; } = 5;
        public int Experience { get; } = 0;
    }
}