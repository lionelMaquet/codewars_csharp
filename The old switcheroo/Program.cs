using System;
using System.Collections.Generic;
using System.Linq;

namespace The_old_switcheroo
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string Vowel2Index(string str)
        {
            List<string> switcheroo = new List<string>();

            for(int i = 0; i < str.Length; i++)
            {
                string c = new List<char>() { 'a', 'e', 'i', 'o', 'u' }.Contains(str[i]) ? (i + 1).ToString() : str[i].ToString();
                switcheroo.Add(c);
            }

            return String.Join("", switcheroo.ToArray());
        }
    }
}
