using System;
using System.Collections.Generic;

namespace I_love_you__a_little___a_lot__passionately_not_at_all
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static string HowMuchILoveYou(int nb_petals)
        {
            return new List<string> { "I love you", "a little", "a lot", "passionately", "madly", "not at all"}[(nb_petals - 1) % 6];
        }
    }
}
