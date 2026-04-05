using polyBanking.models;


internal class Program
{
    private static void Main(string[] args)
    {
        BankAccount Acc1 = new SavingsAccount(101, "Tony", 5000);
        BankAccount Acc2 = new CurrentAccount(102, "Edward", 2000);
        LoanAccount loan = new HomeLoan(103, "Stark", 10000);

        Acc1.Withdraw(6000);
        Acc2.Withdraw(6000);

        Console.WriteLine($"Balance in {Acc1.AccountHolder}'s Savings Account: {Acc1.GetBalance()}");
        Console.WriteLine($"Balance in {Acc2.AccountHolder}'s Current Account: {Acc2.GetBalance()}");
        Console.WriteLine($"Interest on {loan.AccountHolder}'s Home Loan: {loan.CalculateInterest()}");


    }
}