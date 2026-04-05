using OOPS_activity.Models;

internal class Program
{
    public static void Main(string[] args)
    {

        Book book1 = new Book(1, "aaa", "bbb", 500);

        book1.DisplayBookInfo();

        Book book2 = new Book(2, "ccc", "ddd", 800);

        book2.DisplayBookInfo();

        Book book3 = new Book(3, "eee", "fff", 1000);

        book3.DisplayBookInfo();
    }
}