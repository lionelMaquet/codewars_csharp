using System;
using System.Collections.Generic;
using System.Linq;

namespace Descending_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DescendingOrder(342));
        }

        public static int DescendingOrder(int num)
        {
            List<int> list = new List<int>();
            List<int> newList = new List<int>();

            int highest = 0;

            foreach(char c in num.ToString())
            {
                list.Add(int.Parse(c.ToString()));
            }

            while(list.Count > 0)
            {
                foreach (int i in list)
                {
                    if (i > highest)
                    {
                        highest = i;
                    }
                }
                newList.Add(highest);
                list.Remove(highest);
                highest = 0;
            }

            int total = 0;
            foreach (int entry in newList)
            {
                total = 10 * total + entry;
            }

            return total;

        }

    }
}
