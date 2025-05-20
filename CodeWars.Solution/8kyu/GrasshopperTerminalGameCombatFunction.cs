namespace CodeWars.Solution._8kyu;

// Grasshopper - Terminal game combat function
// https://www.codewars.com/kata/586c1cf4b98de0399300001d
public class GrasshopperTerminalGameCombatFunction
{
    public static class Game
    {
        public static float Combat(float health, float damage)
        {
            return health > damage
                ? health - damage
                : 0;
        }
    }
}