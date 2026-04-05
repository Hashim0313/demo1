using Activity_generic.models;
using static System.Reflection.Metadata.BlobBuilder;

internal class Program
{
    private static void Main(string[] args)
    {
     LibraryManagementSystem LMSystem = new LibraryManagementSystem();
        
        LMSystem.AddBook( "George Orwell","222");
        LMSystem.AddBook("To Kill a Mockingbird", "111");
        LMSystem.AddBook("The Great Gatsby", "333\n\n");


        LMSystem.RegisterMember(101, "Alice");
        LMSystem.RegisterMember(102, "Bob");
        LMSystem.RegisterMember(103, "Charlie\n\n");


        LMSystem.CheckoutBooks("1984");
        LMSystem.CheckoutBooks("The Great Gatsby\n");


        LMSystem.ReturnBooks("1984");
        LMSystem.ReturnBooks("The Great Gatsby");

        LMSystem.Print();
    }
}