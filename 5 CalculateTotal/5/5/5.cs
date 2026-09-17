using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _5
{
    class _5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Price");
            string input1 = Console.ReadLine();
            Console.WriteLine("Input Amount");
            string input2 = Console.ReadLine();
            bool IsvalidNumber1 = int.TryParse(input1, out int price);
            bool IsvalidNumber2 = int.TryParse(input2, out int amount);
            if (!IsvalidNumber1 || !IsvalidNumber2)
            {
                Console.WriteLine("Please input valid number");
            }
            else if (price < 0)
            {
                Console.WriteLine("Please input positive number");
            }
            else if (amount < 0)
            {
                Console.WriteLine("Please input positive number");
            }
            else
            {
                int total = CalculateTotal(price,amount);
                Console.WriteLine($"Your Total Money {total}");
            }
        }
        static int CalculateTotal(int price, int amount)
        {
            int Total = price * amount;

            return Total;
        }
    }
}
