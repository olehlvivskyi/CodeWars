namespace CodeWars.Solution._8kyu;

// Classy Extensions
// https://www.codewars.com/kata/55a14aa4817efe41c20000bc
public class ClassyExtensions
{
    public class Cat(string name) : Animal(name)
    {
        public override string Speak() => $"{Name} meows.";
    }

    // This class is created to avoid errors.
    public abstract class Animal(string name)
    {
        public string Name { get; } = name;
        public abstract string Speak();
    }
}