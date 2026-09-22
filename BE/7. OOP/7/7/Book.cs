namespace _7
{
    public class Book
    {
        public string Id;
        public string title;
        public bool IsAvaiable;

        public void PrintInfo()
        {
            Console.WriteLine($"Id cua quyen sach la: {Id}, \n Title: {title}, \n Trang Thai: {IsAvaiable}");
        }
    }

}
