using System;
using System.Linq;

// https://www.codewars.com/kata/526571aae218b8ee490006f4

public class Kata
{
    public static void Main()
    {
        int myNumber = 5; // 101
        CountBits(myNumber); // 2
    }

    public static int CountBits(int n)
    {
        return Convert.ToString(n, 2).ToCharArray().ToList().Count(character => char.GetNumericValue(character) == 1);
    }
}