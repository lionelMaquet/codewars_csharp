using System;
using System.Linq;

namespace Doubleton_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int Doubleton(int num)
        {
            int next = num + 1;
            while(next.ToString().Distinct().Count() != 2)
            {
                next++;
            }
            return next;
        }
    }
}
