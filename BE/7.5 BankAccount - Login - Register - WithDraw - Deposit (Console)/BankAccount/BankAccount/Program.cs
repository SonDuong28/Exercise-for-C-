using Microsoft.Win32;
using System.ComponentModel.Design;
using System.Data;

class Progrram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Register \n UserName: ");
        string usernameinput = Console.ReadLine();
        Console.WriteLine("Password:");
        string passwordinput = Console.ReadLine();
        User user1 = new(usernameinput, passwordinput, 0);
        Console.Clear();
        Console.WriteLine("Register Successfully!");
        while (true){  
            Console.WriteLine($"Login \n UserName: ");
        string username = Console.ReadLine();
            if (username != usernameinput)
            {
                Console.WriteLine("Wrong Username");
                continue;
            }
            Console.WriteLine($"Password: ");
            string checkpass = Console.ReadLine();
            if (passwordinput != checkpass || username != usernameinput)
            {
                Console.Clear();
                Console.WriteLine("Wrong Password");
            }
            else
            {
                Console.Clear();
                user1.LoginSuccess();
                break;
            }
        }
        while (true)
        {
            Console.WriteLine("Do you want to Deposit or Withdraw?, \n 1. Deposit, \n 2. Withdraw");
            string DorW = Console.ReadLine();
            bool checkDorW = int.TryParse(DorW, out int number);
            if (!checkDorW || (number != 1 && number != 2))
            {
                Console.WriteLine("Input 1 or 2");
                continue;
            } if (number == 2 && user1.Balance == 0)
            {
                Console.WriteLine("You cannot Withdraw");
            }else if (number == 2 && user1.Balance != 0)
            {
                Console.WriteLine($"Your Balance: {user1.Balance}, How much do you want to Withdraw? ");
                string withdraw = Console.ReadLine();
                bool isNumber = int.TryParse(withdraw, out int moneyinput);
                if (!isNumber || moneyinput <= 0)
                {
                    Console.WriteLine("You must input number or higher than 0!");
                }
                else if (user1.Balance > moneyinput || user1.Balance == moneyinput)
                {
                    user1.WithDraw(moneyinput);
                    Console.WriteLine($"successfull to withdraw");
                    user1.LoginSuccess();
                } else if (user1.Balance < moneyinput)
                {
                    Console.Clear();
                    Console.WriteLine($"Your Balance Not Enough Money");
                }
            }
            else if (number == 1)
            {
                Console.WriteLine($"Your Balance {user1.Balance} \n How much do you want to Deposit?");
                string deposit = Console.ReadLine();
                Console.Clear();
                bool isNumber = int.TryParse(deposit, out int moneyinput);
                if (!isNumber || moneyinput <= 0)
                {
                    Console.WriteLine("You must input number or higher than 0!");
                }
                else if (moneyinput > 0)
                {
                    user1.Deposit(moneyinput);
                    Console.WriteLine($"successfull to deposit");
                    user1.LoginSuccess();
                }
            }
        }
    } 
}
       