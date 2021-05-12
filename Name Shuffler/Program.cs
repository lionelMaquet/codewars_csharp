using System;

namespace Name_Shuffler
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string NameShuffler(string str)
        {
            return string.Concat(str.Split(" ")[1], " ", str.Split(" ")[0]); 
        }
    }
}
