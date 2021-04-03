using System;
using System.Linq;

namespace DNA_to_RNA_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public string dnaToRna(string dna)
        {
            return string.Concat(dna.Select(e => e == 'T' ? 'U' : e));
        }
    }
}
