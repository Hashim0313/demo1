using Question_4.Models;
internal class Program
{
    private static void Main(string[] args)
    {
        TrainTicket tt1 = new TrainTicket(313,"harry");

        tt1.CalculateFare(145);


        BusTicket bt1 = new BusTicket(1431, "potter");

        bt1.CalculateFare(32);

    }
}