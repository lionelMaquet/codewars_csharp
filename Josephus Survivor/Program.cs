using System;
using System.Collections.Generic;

namespace Josephus_Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            JosSurvivor(7, 3);
        }

        public static int JosSurvivor(int n, int k)
        {
            // This solution technically works, but gets timed out.

            // true means alive, still in the circle
            List<bool> people = new List<bool>();
            for (int i = 0; i < n; i++)
            {
                people.Add(true);
            }

            int current = -1;

            while(people.FindAll(x => x == true).Count != 1)
            {
                
                int added = 0;
                while(added != k) 
                {
                    // "added" gets incremented only if the person currently counted is still alive
                    current++;
                    added += people[current % n] == true ? 1 : 0;
                }
                people[current % n] = false;
            }
            return people.FindIndex(x => x == true) + 1;
        }
    }
}
