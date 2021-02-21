using System;
using System.Collections.Generic;
using System.Linq;

// Status : done
// link : https://www.codewars.com/kata/57eae65a4321032ce000002d/solutions/csharp
// Best way would have been to use LINQ "Select" Method.

namespace Fake_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            FakeBin("45385593107843568");
        }

        public static string FakeBin(string x)
        {
            List<char> fakeBinary = new List<char>();

            foreach (char c in x)
            {
                fakeBinary.Add(int.Parse(c.ToString()) < 5 ? '0' : '1');  
            }

            return new string(fakeBinary.ToArray());
        }
    }
}
