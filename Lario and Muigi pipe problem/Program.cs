using System;
using System.Collections.Generic;
using System.Linq;

namespace Lario_and_Muigi_pipe_problem
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static List<int> PipeFix(List<int> numbers)
        {
            return new List<int>(Enumerable.Range(numbers[0], numbers.Last() - numbers[0] + 1));
        }
    }
}
