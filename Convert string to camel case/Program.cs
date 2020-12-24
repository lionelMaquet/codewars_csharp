using System;
using System.Linq;

public class Kata
{
    public static string ToCamelCase(string str)
    {
        string[] substrings = str.Split('_', '-');
        string res = substrings[0];
        for (int i = 1; i < substrings.Length; i++)
        {
            res += char.ToUpper(substrings[i].First()) + substrings[i].Substring(1);
        }
        return res;
    }
}