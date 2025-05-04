namespace CodeWars.Solution._8kyu;

// What is between?
// https://www.codewars.com/kata/55ecd718f46fba02e5000029
public class WhatIsBetween
{
    public class Kata {
        public static int[] Between(int a, int b) 
        {
            return Enumerable
                .Range(a, b - a + 1)
                .ToArray();
        }
    }
}