﻿using System;

// https://www.codewars.com/kata/54c27a33fb7da0db0100040e

public class Kata
{
    static public void  Main()
    {
        int myNumber = 2;
        IsSquare(myNumber);
    }
    public static bool IsSquare(int n)
    {
        if (n >= 0)
        {
            double sqrt = Math.Sqrt((double)n);
            if (sqrt % 1 == 0)
            { // If it has no decimal values
                return true;
            }
            else
            {
                return false;
            }
        }

        return false;

    }
}