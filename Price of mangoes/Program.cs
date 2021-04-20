using System;

namespace Price_of_mangoes
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int Mango(int quantity, int price)
        {
            return (((quantity - quantity % 3) * 2 / 3) + quantity % 3) * price;
        }
    }
}
