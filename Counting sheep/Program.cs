using System;
using System.Linq;

namespace Counting_sheep
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int CountSheeps(bool[] sheeps)
        {
            return sheeps.ToList().Count(e => e); // same as writing e => e == true
        }
    }
}
