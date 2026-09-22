using _7._1;
using System.Net.Security;

class Program
{
    static void Main(string[] args)
    {
        Book sach1 = new Book("B01", "Hoc C#", true);
        Book sach2 = new Book("B02", "Hoc C#2", false);
        sach1.PrintInfo();
        sach2.PrintInfo();
        //7.3
        Phone phone1 = new("Apple", "iPhone 15", 25000000);
        Phone phone2 = new("Samsung", "S24", 22000000);
        phone1.PrintSpecs();
        phone2.PrintSpecs();
        //7.4
        Console.WriteLine($"Enter your UserName");
        string name = Console.ReadLine();
        Player player1 = new(name);
        player1.DetailPlayer();
        //7.5

    }
}