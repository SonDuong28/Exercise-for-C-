public class User
{
    public string UserName;
    public string Password;
    public int Balance;
    public User(string username, string password, int balance)
    {
        UserName = username;
        Password = password;
        Balance = balance;
    }
    public void LoginSuccess()
    {
        Console.WriteLine($"Your UserName: {UserName}, Your Password: {Password}, Your Balance: {Balance}$");
    }
    public void Deposit(int amount)
    {
        Balance = Balance + amount;
        Console.WriteLine($"Your Balance Now: {Balance}");
    }
    public void WithDraw(int amount) {
        Balance = Balance - amount;
        Console.WriteLine($"Your WithDraw: {amount},Your Balance Now: {Balance}");
    }
}

