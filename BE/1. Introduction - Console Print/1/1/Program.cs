using System;
class Program
{
    static void Main(string[] args)
    {
        string name = "John Doe";
        int age = 22;
        bool IsStudent = true;
        if (age <= 22)
        {
            IsStudent = true;
        }
        else
        {
            IsStudent = false;
        }

        Console.WriteLine($"Name: {name}, \n Age: {age}, \n Is Student? {IsStudent}");
    }
}