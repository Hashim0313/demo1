using System.Collections;

internal class Program
{
    public static void Main(string[] args)
    {
        Hashtable Books = new Hashtable();

        Books.Add("111","book 1");
        Books.Add("222", "book 2");
        Books.Add("333", "book 3");
        Books.Add("444", "book 4");
        Books.Add("555", "book 5");

        Console.WriteLine("Books in the library:");
        foreach (DictionaryEntry book in Books)
        {
            Console.WriteLine($"Key: {book.Key}, Value: {book.Value}");
        }

        string searchKey = "333";
        if (Books . ContainsKey(searchKey))
        {
            Console.WriteLine($"\nLibrary contains key {searchKey}: {Books[searchKey]}");
        }

        string searchTitle = "book 2";
        if (Books.ContainsValue(searchTitle))
        {
            Console.WriteLine($"\nLibrary contains title {searchTitle}");
        }

        string removeKey = "333";
        if (Books.ContainsKey(removeKey))
        {
            Books.Remove(removeKey);
            Console.WriteLine($"\nRemoved book with key {removeKey}");
        }

        Console.WriteLine($"\nTotal number of books in the library: {Books.Count}");
        Console.ReadLine();



    }
}