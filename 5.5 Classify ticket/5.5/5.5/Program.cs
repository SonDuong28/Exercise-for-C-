using System.Net.Sockets;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

class Progrram
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Please input your ticket:");
        string input1 = Console.ReadLine();

        string Classify = GetAccessArea(input1);
        Console.WriteLine(Classify);
        //subtoturial
        Console.WriteLine($"Total of monster you killed?");

        string input2 = Console.ReadLine();
        int basicScore = 10;
        bool IsValidNumber = int.TryParse(input2, out int value);
        if (!IsValidNumber || value < 0)
        {
            Console.WriteLine($"please input real number of monster");
        }
        else
        {
            int TotalScore = CalculateScore(value, basicScore);
            Console.WriteLine(TotalScore);
        }
        //subToturial 2
        Console.WriteLine($"Please input Greade Description: ");
        string grade = Console.ReadLine();
        string GradeDesc = GetGradeDescription(grade);
        Console.WriteLine(GradeDesc);
        //subToturial 3
        Console.WriteLine($"Input your money in bill: ");
        string input4 = Console.ReadLine();
        bool totalAmount = int.TryParse(input4, out int money);
        if (!totalAmount || money < 0)
        { Console.WriteLine($"please input real total money"); }
        else
        {
            int TotalMoney = CalculateFinalPrice(money);
            Console.WriteLine($"Total money after discount: {TotalMoney}");
        }

    }
    static string GetAccessArea(string ticketType)
    {
        if (ticketType == "VIP")
        {
            return "Ticket Type: VIP \n Khu vực ghế salon và đồ uống miễn phí";
        }
        else if (ticketType == "Standard")
        {
            return "Ticket Type: Standard \n Khu vực ghế ngồi chung";
        }
        else
        {
            return "Vé không hợp lệ, mời ra ngoài";
        }
    }
    //subToturial1
    static int CalculateScore(int value, int basicScore)
    {
        if (value <= 5)
        {
            return basicScore * value;
        }
        else if (value > 5)
        {
            return basicScore * value + 50;
        }
        else
        {
            return value;
        }
    }
    //subToturial2
    static string GetGradeDescription(string grade)
    {
        if (grade == "A")
        {
            return "Exellenct";
        }
        else if (grade == "B")
        {
            return "Good";
        }
        else if (grade == "C")
        {
            return "Normal";
        }
        else 
        { return "Bad"; }
            
    }
    static int CalculateFinalPrice (int money)
    {
        if (money < 500000){
            return money;
        }else if (money > 500000 && money < 1000000)
        {
            int moneydiscount1 = (money * 10) / 100;
            return money - moneydiscount1;
        }else if (money >= 1000000 )
        {
            int moneydiscount2 = (money * 20) / 100;
            return money - moneydiscount2;
        } return money;
    }
}