using System;
using System.Collections.Generic;
using System.Text;

namespace _4
{
    class _4
    {
        static void Main(string[] args) {
            Console.WriteLine("Input amount: ");
            string input1 = Console.ReadLine();
            bool IsValidAmount = int.TryParse(input1, out int amount);

            if (!IsValidAmount)
            {
                Console.WriteLine("Vui lòng nhập số nguyên");
            }else if (amount <= 0)
            {
                Console.WriteLine("Số lượng không hợp lệ");
            }
            else if (amount <= 10) {
                Console.WriteLine("Có thể đặt hàng");
            }
            else Console.WriteLine("Vượt quá giới hạn");

            Console.WriteLine("Enter Book");
            string input2 = Console.ReadLine();
            string name = "Hello";
            bool IsValidBook = !string.IsNullOrWhiteSpace(input2);
            if (IsValidBook & input2 == name) {
                Console.WriteLine("Success");
            } else Console.WriteLine("Error");
        }
    }
}
