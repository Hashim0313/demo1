using Exercise.Interface;
using Exercise.Models;
using Exercise.Enums;
using Exercise.Manager;
using Exercise.Repository;
internal class Program
{
    public static void Main(string[] args)
    {
        PublicManager manager = new PublicManager();
        manager.DisplayMenu();
    }
}