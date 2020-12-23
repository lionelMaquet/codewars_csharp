using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

// https://www.codewars.com/kata/55f8a9c06c018a0d6e000132
public class Kata
{
    static public void Main()
    {
        string myPin = "";
        ValidatePin(myPin);
    }

    public static bool ValidatePin(string pin)
    {

        if (!new List<int>() { 4, 6 }.Any(x => x == pin.Length)) return false;  // if pin's length is neither 4 nor 6

        if (pin.Any(c => char.GetNumericValue(c) == -1)) return false; // if any is not a number (ie : -123)

        try { int Parsed = int.Parse(pin); } catch (Exception e) { return false; } // if pin is not only composed of ints

        return true; // ultimately return true if it's come to this point

    }
}