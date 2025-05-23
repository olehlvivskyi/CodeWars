namespace CodeWars.Solution._8kyu;

// Simple Fun #1: Seats in Theater
// https://www.codewars.com/kata/588417e576933b0ec9000045
public class SimpleFun1SeatsInTheater
{
    public class Kata
    {
        public static int SeatsInTheater(int nCols, int nRows, int col, int row) => (nCols - col + 1) * (nRows - row);
    }
}