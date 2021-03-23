using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Reversed_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int[] ReverseSeq(int n)
        {
            return Enumerable.Range(1, n).Reverse().ToArray();
        }
    }
}
