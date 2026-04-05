using GenericArraylist.models;

internal class Program
{
    private static void Main(string[] args)
    {
        Library library = new Library();

        library.AddBook(new Book("1984", "George Orwell\n"));
        library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee\n"));
        library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald\n\n"));
        
        library.DisplayBooks();
        
        library.RemoveBook("The Great Gatsby\n\n");

        library.DisplayBooks();
    }
}