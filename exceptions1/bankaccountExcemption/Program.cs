using bankaccountException.exceptions;
using bankaccountException.models;

internal class Program
{

    public static void Main(string[] args)
    {

        BankAccount account = new BankAccount(1000);
        Console.WriteLine($"current balance : {account.Balance}  ");
        do
        {
            
            try
            {
                if(account.Balance == 0)
                {
                    Console.WriteLine("Your account balance is zero. Exiting the program.");
                    Environment.Exit(0);
                }
                Console.WriteLine("enter amount to withdraw");
                int amount = Convert.ToInt32(Console.ReadLine());
                account.Withdraw(amount);
                Console.WriteLine($"New balance : {account.Balance}  ");
            }

            catch (InsufficientFundsException ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
            catch (InvalidAmountException ex)
            {
                Console.WriteLine($"error : {ex.Message}");
            }
        } while (true);

    }
}
    