using abstraction_activity.models;

internal class Program
{
    public static void Main(string[] args)
    {

        ElectronicProduct EProduct = new ElectronicProduct("smartphone", 10, 699.99m, "TechBrand", 24);

        GroceryProduct GProduct1 = new GroceryProduct("milk", 20, 50.00m, new DateTime (2027,7,7));

        GroceryProduct GProduct2 = new GroceryProduct("bread", 30, 20.00m, new DateTime (2024,12,31));


        
        
        ShoppingCart cart = new ShoppingCart(5);

        cart.AddProduct(EProduct);
        cart.AddProduct(GProduct1);
        cart.AddProduct(GProduct2);

        cart.DisplayCartContents();

        cart.RemoveProduct(30);

       cart.CalculateTotalPrice();

    }
}