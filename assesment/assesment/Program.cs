using System;
using assesment.models;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter product id: ");
        int productId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter product name: ");
        string productName = Console.ReadLine();

        Console.WriteLine("Enter price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter product type: \n1. Electronics \n2. Clothing");
        string choice = Console.ReadLine();

        Product selectedProduct;

        switch (choice)
        {
            case "1":
                selectedProduct = new Electronics(productId, productName);
                break;
            case "2":
                selectedProduct = new Clothing(productId, productName);
                break;
            default:
                Console.WriteLine("Invalid product type selected.");
                return;
        }

        double discount = selectedProduct.CalculateDiscount(price);
        double finalPrice = price - discount;

        Console.WriteLine($"\nProduct Details:");
        Console.WriteLine($"ID: {selectedProduct.ProductId}");
        Console.WriteLine($"Name: {selectedProduct.ProductName}");
        Console.WriteLine($"Original Price: ₹{price}");
        Console.WriteLine($"Discount: ₹{discount}");
        Console.WriteLine($"Final Price: ₹{finalPrice}");
    }
}