using System;
using System.Collections.Generic;

namespace Double_Cola
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            WhoIsNext(names, 1);
        }

        public static string WhoIsNext(string[] names, long n)
        {
            long position = 0;
            List<string> queue = new List<string>();
            foreach(string name in names)
            {
                queue.Add(name);
            }

            while(position != n - 1)
            {
                queue.Add(queue[0]);
                queue.Add(queue[0]);
                queue.RemoveAt(0);
                position++;
            }

            return queue[0];
        }
    }
}
