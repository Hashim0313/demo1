using generic_activity.models;

internal class Program
{
    private static void Main(string[] args)
    {
        LibraryManagement library = new LibraryManagement();
        while (true)
        {
            Console.WriteLine("\nLibrary Management System");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Register Member");
            Console.WriteLine("3. Checkout Book");
            Console.WriteLine("4. Return book");
            Console.WriteLine("5. Add announcement");
            Console.WriteLine("6. view library");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    library.AddBook();
                    break;
                case "2":
                    library.RegisterMember();
                    break;
                case "3":
                    library.CheckoutBooks();
                    break;
                case "4":
                    library.ReturnBooks();
                    break;
                    case "5":
                    library.MakeAnnouncement();
                    break;
                    case "6":
                    library.Print();
                    break;
                    case "7":
                    return;
            }
        }

        
    }
}