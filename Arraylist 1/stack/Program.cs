using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        Stack books = new Stack();

        books.Push(1);
        books.Push(2);
        books.Push(3);
        books.Push(4);


        Console.WriteLine("Books in the stack:"+books.Count);

        Console.WriteLine("book in the top of the stack: "+books.Peek());

        string bookToFind = "book 3";
        if (books.Contains(bookToFind))
        {
            Console.WriteLine($"\nStack contains {bookToFind}");
        }
        else
        {
            Console.WriteLine($"\nStack does not contain {bookToFind}");
        }

        string poppedBook = books.Pop().ToString();
        Console.WriteLine($"\nPopped book: {poppedBook}");

        Console.WriteLine($"\nTotal number of books in the stack after popping one: {books.Count}");
        Console.ReadLine();

    }
}