using System;
using System.Collections.Generic;

namespace Count_by_X
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int[] CountBy(int x, int n)
        {
            List<int> ints = new List<int>();
            int i = x;
            while(ints.Count != n)
            {
                if (i % x == 0)
                {
                    ints.Add(i);
                }
                i++;
            }
            return ints.ToArray();
        }
    }
}
