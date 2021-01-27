using System;
using System.Collections.Generic;

namespace Greed_Is_Good
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] hrow = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(Score(hrow));
        }

        public static int Score(int[] dice)
        {
            int score = 0;
            List<int> ocurrences = new List<int>() { 0, 0, 0, 0, 0, 0, 0 };

            foreach (int num in dice) { ocurrences[num]++; }

            while (ocurrences.Exists(x => x != 0))
            {
                for (int i = 0; i <= 6; i++)
                {
                    if (ocurrences[i] >= 3)
                    {
                        score += i == 1 ? 1000 : i * 100;
                        ocurrences[i] -= 3;
                    }

                    if (ocurrences[i] > 0)
                    {
                        if (i == 1 || i == 5)
                        {
                            score += i == 1 ? 100 : 50;
                            ocurrences[i] -= 1;
                        }

                        else
                        {
                            ocurrences[i] = 0;
                        }
                    }


                }

            }

            return score;
        }
    }
}
