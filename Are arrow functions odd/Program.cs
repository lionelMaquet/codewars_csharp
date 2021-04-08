using System;
using System.Collections.Generic;
using System.Linq;

namespace Are_arrow_functions_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static List<int> Odds(List<int> values) =>
    // arrow it
    values.Where( e => e % 2 == 1 )
          .ToList();
    }
}
