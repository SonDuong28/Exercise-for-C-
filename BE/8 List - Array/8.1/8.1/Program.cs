class Program
{
    static void Main(string[] args)
    {
        List<Book> thuvien = new List<Book>();
        //base
        Book sach1 = new("BC01", "Hoc C#1", true);
        thuvien.Add(sach1);
        //extra
        thuvien.Add(new Book("BC02", "Hoc C#2", true));
        thuvien.Add(new Book("BC03", "Hoc C#3", false));
        Book Findbook = FindBookById("BC02", thuvien);
        if (Findbook != null)
        {
            Console.WriteLine($"Tim Thay Sach: {Findbook.Title}");
        } else { Console.WriteLine("Khong tim thay sach"); }
    }
    public static Book FindBookById(string Id, List<Book> thuvien)
    {
        foreach (Book book in thuvien) 
        {
            if (book.Id == Id)
            {
              return book;
            } 
        }return null;
    }
}