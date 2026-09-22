public class Book
{
    public string Id;
    public string Title;
    public bool IsAvailable;

    public Book(string id, string title, bool isAvailable)
    {
        Id = id;
        Title = title;
        IsAvailable = isAvailable;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Id of this book: {Id}, Title: {Title}, Avalable: {IsAvailable}");
    }
}
