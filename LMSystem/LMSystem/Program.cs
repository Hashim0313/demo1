using LMSystem.models;
using static LMSystem.models.Book;


internal class program
{
    private static void Main(string[] args)
    {

        EBook eb = new EBook(101, "C#", "John Doe", 4, 50, "PDF");
        PrintedBook pb = new PrintedBook(201, "Design", "Gamma", 10, 200, "Addison");

        BorrowTransaction bt = new BorrowTransaction(201, "Alice", DateOnly.FromDateTime(DateTime.Today), 10);
            
        bt.CalculateFine();

        Console.WriteLine("Books Borrowed:");
        Console.WriteLine($"EBook:{eb.Title} by {eb.Author} (File Size:{eb.fileSize}MB,Format:{eb.format})");
        Console.WriteLine($"PrintedBook:{pb.Title} by {pb.Author} (Pages:{pb.pages},Publisher:{pb.publisher})");

        Console.WriteLine("\nTransaction Details:");
        Console.WriteLine($"Transaction Id:{bt.transactionId}\nMember Name:{bt.memberName}\nLate Days:{bt.days}\nFine:${bt.fine}");

    }
}



