class Program
{
    static void Main(String[] args)
    {
        int[] cart = { 150000, 45000, 600000, 12000, 850000 };
        int total = 0;
        int max = 0;
        foreach (int item in cart) {
            int finalPrice = CalculateItemPrice(item);
            Console.WriteLine($"Gia mon hang sau giam: {finalPrice}");
            if (finalPrice > max) { 
                max = finalPrice;
            }
            total = total + finalPrice;
        }
        Console.WriteLine($"Tong gia tri cua don hang: {total}");
        Console.WriteLine($"mon do mac nhat: {max}");
        Console.WriteLine($"vui long nhap so tien khach dua:");
        string moneygive = Console.ReadLine();
        bool Truemoney = int.TryParse(moneygive, out int moneyreal);
        if (!Truemoney)
        {
            Console.WriteLine("Plese input real money!");
        }
        else if (moneyreal < total)
        {
            Console.WriteLine("Khach Hang dua thieu tien");
        }
        else Console.WriteLine($"Tien thoi lai cho khach {moneyreal - total}");
    }
    static int CalculateItemPrice(int price)
    {
        if (price >= 500000)
        {
            int pricereduce = price - 50000;
            return pricereduce;
        }
        else if (price >= 100000 && price < 500000)
        {
            int pricereduce = price - 10000;
            return pricereduce;
        }else return price;
    }
}