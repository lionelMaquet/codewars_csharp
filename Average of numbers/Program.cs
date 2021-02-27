using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Averages(new int[] { 1 });
        }

        public static double[] Averages(int[] numbers)
        {
            List<double> doubles = new List<double>();

            for (int i = 0; i < numbers.Count() - 1; i++)
            {
                doubles.Add(((double)numbers[i] + (double)numbers[i + 1]) / 2);
            }

            return doubles.Count > 0 ? doubles.ToArray() : new double[] { };
        }
    }
}
