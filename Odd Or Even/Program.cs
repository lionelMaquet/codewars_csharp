﻿using System;
using System.Linq;

namespace Odd_Or_Even
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string OddOrEven(int[] array)
        {
            return array.ToList().Sum() % 2 == 0 ? "even" : "odd";
        }
    }
}
