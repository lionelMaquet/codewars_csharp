using System;

namespace Short_long_short
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string Solution(string a, string b)
        {
            return a.Length > b.Length ? string.Concat(b, a, b) : string.Concat(a, b, a);
        }
    }
}
