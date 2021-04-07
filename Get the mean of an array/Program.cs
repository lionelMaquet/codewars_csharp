using System;
using System.Linq;

namespace Get_the_mean_of_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int GetAverage(int[] marks)
        {
            return marks.Sum() / marks.Length;
        }
    }
}
