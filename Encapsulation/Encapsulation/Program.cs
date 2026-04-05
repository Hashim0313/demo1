using Encapsulation.models;

public class Program
{
    public static void Main(string[] args)
    {
       BankAccount account = new BankAccount(1000);

        account.Deposit(500);

        account.Withdraw(300);

        account.Withdraw(1500);


        Console.WriteLine($"current balance: {account.GetBalance()}");
    }
}