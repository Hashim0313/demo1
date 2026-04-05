using Abstraction.models;
using System.Globalization;

internal class Program
{
    public static void Main(string[] args)
    {
        ATM myATM = new BankATM(500.00m);

        myATM.CheckBalance();
        myATM.WithdrawMoney(100.00m);
        myATM.DepositMoney(200.00m);
        myATM.CheckBalance();
    }
}