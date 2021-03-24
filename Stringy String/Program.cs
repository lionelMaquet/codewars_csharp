using System;
using System.Linq;

namespace Stringy_String
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string Stringy(int size)
        {
            return string.Concat(new string('1', size).Select((e,i) => i % 2 == 1 ? '0' : '1'));
        }
    }
}
