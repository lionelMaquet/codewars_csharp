using System;

namespace Cat_years_Dog_years
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int[] humanYearsCatYearsDogYears(int humanYears)
        {
            int catYears = humanYears > 2 ? 24 + ((humanYears - 2) * 4) : (humanYears == 1 ? 15 : 24);
            int dogYears = humanYears > 2 ? 24 + ((humanYears - 2) * 5) : (humanYears == 1 ? 15 : 24);
            return new int[] { humanYears, catYears, dogYears };
        }
    }
}
