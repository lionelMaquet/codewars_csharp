using System;
using System.Linq;

namespace Reversed_Words
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string ReverseWords(string str)
        {
            return String.Join(' ', str.Split(' ').Reverse());
        }
    }
}
