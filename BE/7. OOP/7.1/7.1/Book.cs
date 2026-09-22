using System;
using System.Collections.Generic;
using System.Text;

namespace _7._1
{
    public class Book
    {
       public string Id;
       public string Title;
       public bool IsAvaiable;
        
        public Book(string id, string title, bool isAvaiable)
        {
            Id = id;
            Title = title;
            IsAvaiable = isAvaiable;
        }
       
       public void PrintInfo()
        {
            Console.WriteLine($"Id cua quyen sach la: {Id}, \n Title: {Title}, \n Trang Thai: {IsAvaiable}");
        }
    }
}