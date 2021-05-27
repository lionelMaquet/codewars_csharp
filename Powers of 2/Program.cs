using System;
using System.Collections.Generic;
using System.Numerics;

namespace Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static BigInteger[] PowersOfTwo(int n)
        {
            List<BigInteger> powers = new List<BigInteger>();

            for (int i = 0; i <= n; i++)
            {
                powers.Add((BigInteger)Math.Pow(2, i));
            }
            
            return powers.ToArray();
        }
    }
}
