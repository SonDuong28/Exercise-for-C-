using System;
using System.Collections.Generic;
using System.Text;

namespace _7._1
{
    public class BankAccount
    {
        public string UserName;
        public string Password;
        public int Balance;

        public BankAccount(string userName, string password,int balance)
        {
            UserName = userName;
            Password = password;
            Balance = 50000;
        }
        public void LoginSuccess ()
        {
            Console.WriteLine($"Your UserName: {UserName}, Your Password: {Password}, Your Balance{Balance}");
        }
        public void Deposit(int amount)
        {
            Balance = Balance + amount;
            Console.WriteLine($"Your Balance Now: {Balance}");
        }
    }
}
