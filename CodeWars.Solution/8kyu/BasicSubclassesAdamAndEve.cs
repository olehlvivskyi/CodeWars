namespace CodeWars.Solution._8kyu;

// Basic subclasses - Adam and Eve
// https://www.codewars.com/kata/547274e24481cfc469000416
public class BasicSubclassesAdamAndEve
{
    public abstract class Human;

    public class Man : Human;
        
    public class Woman : Human;
    
    public abstract class God
    {
        public static Human[] Create() => [new Man(), new Woman()];
    }
}