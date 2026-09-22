class Program
{
    static void Main(string[] args)
    {
        List<Book> thuvien = new List<Book>();
        //base
        Book sach1 = new("BC01","Hoc C#1", true);
        thuvien.Add(sach1);
        //extra
        thuvien.Add(new Book("BC02", "Hoc C#2", true));
        thuvien.Add(new Book("BC03", "Hoc C#3", false));

        foreach(Book book in thuvien)
        {
            //check book is available
            //if (book.IsAvailable == true)
            {
                book.PrintInfo();
            }
        }
    }
}