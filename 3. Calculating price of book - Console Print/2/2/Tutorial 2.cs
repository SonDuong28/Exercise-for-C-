using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _2
{
    class _2
    {
        static void Main(string[] args)
        {
            string book = "hehe";
            int price = 12000;
            int amount = 3;
            int ship = 5000;
            if (amount < 1)
            {
                price = 0;
                ship = 0;
            } else
            {
                ship = 5000;
            }
            int total = (price * amount) + ship;
            Console.WriteLine($"Name: {book}, Price: {price},Amount: {amount}, Ship: {ship}, Total: {total}");
        }
    }
}
