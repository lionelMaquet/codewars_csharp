using System;

namespace Will_there_be_enough_space
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int Enough(int cap, int on, int wait)
        {
            return cap >= on + wait ? 0 : Math.Abs(cap - (on + wait)) ; 
        }
    }
}
