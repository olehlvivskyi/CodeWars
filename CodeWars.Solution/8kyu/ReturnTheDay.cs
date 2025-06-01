namespace CodeWars.Solution._8kyu;

// Return the day
// https://www.codewars.com/kata/59dd3ccdded72fc78b000b25
public class ReturnTheDay
{
    public class Kata
    {
        public static string WhatDay(int n)
        {
            return n switch
            {
                2 => "Monday",
                3 => "Tuesday",
                4 => "Wednesday",
                5 => "Thursday",
                6 => "Friday",
                7 => "Saturday",
                1 => "Sunday",
                _ => "Wrong, please enter a number between 1 and 7"
            };
        }
    }
}