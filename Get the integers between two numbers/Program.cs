using System;
using System.Collections.Generic;
using System.Linq;

namespace Get_the_integers_between_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int[] Range(int startNum, int endNum)
        {
            return endNum - startNum > 0 ? Enumerable.Range(startNum + 1, endNum - startNum - 1).ToArray() : new int[] { };
        }
    }
}
