using books.Repository;
using books.Models;
using books.Inteface;
using books.Enums;
using books.Manager;
internal class Program
{
    public static void Main(string[] args)
    {
        Publicm Manager1 = new Publicm();
        Manager1.DisplayMenu();
    }
}