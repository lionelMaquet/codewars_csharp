using System;
using System.Linq;

namespace Sum_Of_Positive
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int PositiveSum(int[] arr)
        {
            return arr.Select(e => e > 0 ? e : 0).Sum();
        }
    }
}
