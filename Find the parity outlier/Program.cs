﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace Find_the_parity_outlier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int Find(int[] integers)
        {
            return integers.Count(x => x % 2 == 0) > 1 ? integers.ToList().Find(x => x % 2 != 0) : integers.ToList().Find(x => x % 2 == 0);
        }

    }
}
