using System;
using System.Linq;

namespace Vowel_Count
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int GetVowelCount(string str)
        {
            return str.Count(i => "aeiou".Contains(i));
        }
    }
}
