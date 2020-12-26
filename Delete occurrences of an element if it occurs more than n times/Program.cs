using System;
using System.Collections.Generic;
using System.Linq;

// link : https://www.codewars.com/kata/554ca54ffa7d91b236000023/train/csharp
public class Kata
{
    public static int[] DeleteNth(int[] arr, int x)
    {
        List<int> newArray = new List<int>();

        foreach(int num in arr)
        {
            if (newArray.FindAll(y => y == num).Count() < x)
            {
                newArray.Add(num);
            }
        }

        return newArray.ToArray();
    }
}