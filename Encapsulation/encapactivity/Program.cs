using EncapAbstrInheriActivity.Models;
using encapactivity.models;

internal class Program
{
    private static void Main(string[] args)
    {
        ElectronicProduct ep = new ElectronicProduct(101, "phone", 50000, 4, 6, "Apple");

        ClothingProduct cp = new ClothingProduct(201, "Shirt", 1000, 10, 44, "Cotton");

        Ordering od = new Ordering(007, "James.B", DateOnly.FromDateTime(DateTime.Now));

        od.p[0] = ep;
        od.p[1] = cp;

        od.DisplayDetails();
    }
}