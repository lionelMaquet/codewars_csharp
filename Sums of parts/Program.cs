using System;
using System.Collections.Generic;
using System.Linq;

namespace Sums_of_parts
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int[] PartsSums(int[] ls)
        {
            int total = ls.ToList().Sum();
            List<int> partsSums = new List<int>() { total };
            for (int i = 0; i < ls.Count(); i++)
            {
                partsSums.Add(total - ls[i]);
                total -= ls[i];
            }

            return partsSums.ToArray();
        }
    }
}
