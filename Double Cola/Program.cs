using System;
using System.Collections.Generic;

namespace Double_Cola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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


            /*
            List<int> counters = new List<int>();
            counters.Add(names.Length - 1);
            
            while(counters[counters.Count - 1] < n)
            {
                counters.Add(counters[counters.Count - 1] + counters[counters.Count - 1] * 2);
            }

            int lastNameMultiplier = 0;
            int nextNameMultiplier;
            for (int i = 0; i < n; i++)
            {
                if (counters[i] > n)
                {
                    lastNameMultiplier = counters[i - 1];
                    nextNameMultiplier = counters[i];
                    break;
                }
            }
            */


        }


    }
}
