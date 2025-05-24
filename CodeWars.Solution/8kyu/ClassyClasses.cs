namespace CodeWars.Solution._8kyu;

// Classy Classes
// https://www.codewars.com/kata/55a144eff5124e546400005a
public class ClassyClasses
{
    public class Person(string name, int age)
    {
        public int Age { get; private set; } = age;
        public string Name { get; private set; } = name;

        public string Info() => $"{Name}s age is {Age}";
    }
}