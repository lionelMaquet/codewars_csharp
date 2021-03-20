using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter_out_the_geese
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
        {
            string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };
            return birds.Where(e => !geese.Contains(e)).ToList();
        }
    }
}
