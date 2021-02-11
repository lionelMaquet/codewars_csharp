using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    }

    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        List<T> outlist = new List<T>();

        foreach(var e in iterable)
        {
            if (outlist.Count == 0 || !e.Equals(outlist[outlist.Count - 1]))
            {
                outlist.Add(e);
            }
        }
        return outlist;
    }
}

