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
        Console.WriteLine($"Cac Sach Hien Co Trong Thu Vien");
        foreach (Book b in thuvien)
        {
            Console.WriteLine($"Id: {b.Id} \n ten sach {b.Title} \n");
        }
        while (true)
        {
            Console.WriteLine($"Input ID Book you want to borrow or input exit to exit");
            string input1 = Console.ReadLine();
            if (input1.ToLower() == "exit")
            {
                break;
            }else if (string.IsNullOrEmpty(input1)) {
                Console.WriteLine("Please input ID");
                continue;
            } Book bookborrow = FindBookById(input1, thuvien);
            {
                if (bookborrow == null) 
                {
                    Console.WriteLine($"Book is not available");
                    continue;
                } 
            } bool IsavailableBook = bookborrow.IsAvailable;
            if (!IsavailableBook)
            {
                Console.WriteLine($"Book is not available");
            }
            else Console.WriteLine($"Here is your book: {bookborrow.Title}");
            bookborrow.IsAvailable = false;
        }
    }
    public static Book FindBookById(string Id, List<Book> thuvien)
    {
        foreach (Book book in thuvien)
        {
            if (book.Id == Id)
            {
                return book;
            }
        }
        return null;
    }
}