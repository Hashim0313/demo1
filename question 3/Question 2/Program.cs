using Question_2.Models;
internal class Program
{
    private static void Main(string[] args)
    {
        SavingsAccount sa1 = new SavingsAccount(20,"jhon");



        CurrentAccount ca1 = new CurrentAccount(1525, "mike");


        sa1.CalculateInterest(27500);

                                                         Console.WriteLine();

        ca1.CalculateInterest(52350);

    }
}