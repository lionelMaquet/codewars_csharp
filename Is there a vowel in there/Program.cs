using System;
using System.Collections.Generic;
using System.Linq;

namespace Is_there_a_vowel_in_there
{
    class Program
    {
        static void Main(string[] args)
        {
            IsVow(new object[] { 118, 117, 120, 121, 117, 98, 122, 97, 120, 106, 104, 116, 113, 114, 113, 120, 106 });
        }

        public static object[] IsVow(object[] a)
        {
            return a.Select(e => new List<char>() { 'a', 'e', 'i', 'o', 'u' }.Contains(Convert.ToChar(e)) ? Convert.ToChar(e).ToString() : e).ToArray<object>();
        }
    }
}
