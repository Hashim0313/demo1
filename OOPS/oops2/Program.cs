using oops2.Models;

internal class Program
{
    public static void Main(string[] args)
    {

        Book book1 = new Book(1, "aaa", "oooo", 2020);
        book1.DisplayInfo();

        Console.WriteLine("\n");

        Book book2 = new Book(2, "bbb", "gggg", 2025);
        book2.DisplayInfo();


    }
}