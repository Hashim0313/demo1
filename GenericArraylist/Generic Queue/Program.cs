
internal class Program
{
    private static void Main(string[] args)
    {
        Queue<string> Tickets = new Queue<string>();

        Tickets.Enqueue("Ticket1");
        Tickets.Enqueue("Ticket2");
        Tickets.Enqueue("Ticket3");
        Tickets.Enqueue("Ticket4");


        Console.WriteLine("Total Tickets in the queue:"+Tickets.Count);

        Console.WriteLine("Next Ticket to be processed: " + Tickets.Peek());

        while(Tickets.Count >0)
        {
            string ticket = Tickets.Dequeue();
            Console.WriteLine("Processing"+ticket);
        }

        Console.WriteLine("All tickets processed. Remaining tickets in the queue: " + Tickets.Count);
        Console.ReadLine();

    }
}