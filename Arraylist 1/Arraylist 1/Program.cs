using System.Collections;

internal class Program
{
    public static void Main(string[] args)
    {
        ArrayList Books = new ArrayList();

        Books.Add("book 1");
        Books.Add("book 2");
        Books.Add("book 3");
        Books.Add("book 4");
        Books.Add("book 5");

        Console.WriteLine("Books in the library:");
        DisplayBooks(Books);

        Books.Remove("book 3");
        Console.WriteLine("\nBooks in the library after removing book 3:");
        DisplayBooks(Books);

        Books.RemoveAt(1);
        Console.WriteLine("\nBooks in the library after removing book at index 1:");
        DisplayBooks(Books);

        Books.Insert(0, "book 6");
        Console.WriteLine("\nBooks in the library after inserting book 6 at index 0:");
        DisplayBooks(Books);

        int index = Books.IndexOf ("Book 1");
        Console.WriteLine($"\nIndex of Book 4: {index}");


        bool containsBook2 = Books.Contains("book 2");
        Console.WriteLine($"\nLibrary contains book 2: {containsBook2}");

        Console.WriteLine($"\nTotal number of books in the library: {Books.Count}");


        Books.Sort();
        Console.WriteLine("\nBooks in the library after sorting:");
        DisplayBooks(Books);

    }

    public static void DisplayBooks(ArrayList Books)
    {
        foreach (string book in Books)
        {
            Console.WriteLine(book);
        }


    }


}