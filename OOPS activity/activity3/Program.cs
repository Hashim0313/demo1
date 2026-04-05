using activity3.models;

internal class Program
{
    public static void Main(string[] args)
    {
        Product product1 = new Product(1, "Laptop", 50000, 2);
        product1.CalculateTotalPrice();

        Product product2 = new Product(2, "Smartphone", 30000, 3);
        product2.CalculateTotalPrice();

    }
}