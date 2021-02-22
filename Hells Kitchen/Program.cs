using System;
using System.Collections.Generic;
using System.Linq;

namespace Hells_Kitchen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string Gordon(string a)
        {
            return string.Concat(string.Concat(a.Select(e => e == 'a' ? '@' : (new List<char>() { 'e', 'i', 'o', 'u' }.Contains(e) ? '*' : char.ToUpper(e)))).Replace(" ", "!!!! "),"!!!!");
        }
    }
}
