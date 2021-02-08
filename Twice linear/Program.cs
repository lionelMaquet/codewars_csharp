using System;
using System.Collections.Generic;

namespace Twice_linear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DblLinear(50));
        }

        public static int DblLinear(int n)
        {
            List<int> dblLinearList = new List<int>() { 1 };

            while (dblLinearList.Count < n + 1)
            {
                dblLinearList.Add(NextDblLinear(dblLinearList));
            }

            dblLinearList.Sort();
            return dblLinearList[n];
        }

        public static int NextDblLinear(List<int> p)
        {
            List<int> TempList = new List<int>();
            foreach (int o in p)
            {
                int x = 2 * o + 1;
                int y = 3 * o + 1;
                new List<int>() { x, y }.ForEach(el => { if (!p.Contains(el)) { TempList.Add(el); } });
            }
            TempList.Sort();
            return TempList[0];
        }
    }
}
