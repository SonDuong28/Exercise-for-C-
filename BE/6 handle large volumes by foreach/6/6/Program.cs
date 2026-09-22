using System.Numerics;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        int[] number = { 2, 0, 5, -1, 3 };
        int dem = 0;
        int tong = 0;
        foreach (int i in number)
        {
            Console.WriteLine(i);
            if (i > 0)
            {
                dem = dem + 1;
                tong = tong + i;
            }
        }
        Console.WriteLine($"So phan tu hop le: {dem}");
        Console.WriteLine($"Tong so phan tu hop le: {tong}");
        //subtask
        string[] names = { "Hoa", "An", "Binh", "An", "Tuan", "An" };
        int soluong = 0;
        string tenAn = "An";
        foreach (string i in names)
        {
            Console.WriteLine(i);
            if (i == tenAn)
            {
                soluong = soluong + 1;
            }
        }
        Console.WriteLine($"So luong ban ten An la: {soluong}");

        //subtask
        Console.WriteLine("Please enter the number:");
        string number1 = Console.ReadLine();
        bool Checknumber = int.TryParse(number1, out int realnumber);
        if (!Checknumber)
        {
            Console.WriteLine("Please input the number");
        }
        else onetoten(realnumber);

        //subtask3
        int[] scores = { 3, 3, 5, 6, 7, 100, 2, 4};
        int max = 0;
        foreach (int i in scores)
        {
            if (i > max)
            {
                max = i;
            }
        }
        Console.WriteLine($"the number highest is: {max}");
    }
    static void onetoten(int realnumber)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{realnumber} x {i} = {realnumber * i}");
        }
    }
}