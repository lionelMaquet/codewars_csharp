using System;
using System.Collections.Generic;

// link to kata : https://www.codewars.com/kata/5254ca2719453dcc0b00027d/train/csharp
// NOT FINISHED

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static List<string> SinglePermutations(string s)
        {

            List<string> outlist = new List<string>();

            if (s.Length == 1)
            {
                outlist.Add(s);
                return outlist;
            }

            else
            {

            }

            
            // Your code here!
            return null;
        }
    }
}
