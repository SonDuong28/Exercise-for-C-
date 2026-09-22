using _7;

class Program 
{
    static void Main(string[] args)
    {
        Book sach1 = new Book();
        sach1.Id = "B01";
        sach1.title = "Hoc C# 1";
        sach1.IsAvaiable = false;
        Book sach2 = new Book();
        sach2.Id = "B02";
        sach2.title = "Hoc C# 2";
        sach2.IsAvaiable = false;
        sach1.PrintInfo();
        sach2.PrintInfo();
    }
}