using Workshop.Interface;
using Workshop.Manager;
internal class Program
{
    public static void Main(string[] args)
    {
        IMenu menu = new PublicManager();
        menu.DisplayMenu();
    }
}