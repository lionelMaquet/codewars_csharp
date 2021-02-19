using System;

namespace Transportation_on_vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int RentalCarCost(int d)
        {
            int totalWithoutOffer = d * 40;
             
            if (d >= 3)
            {
                int totalWithOffer = d >= 7 ? totalWithoutOffer - 50 : totalWithoutOffer - 20;
                return totalWithOffer;
            }

            return totalWithoutOffer;
        }
    }
}
