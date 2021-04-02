using System;

namespace The_wide_mouthed_frog
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string MouthSize(string animal)
        {
            return animal.ToLower() == "alligator" ? "small" : "wide";
        }
    }
}
