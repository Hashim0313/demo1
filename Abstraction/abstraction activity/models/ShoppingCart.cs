using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_activity.models
{
    public class ShoppingCart
    {

        public Product[] products;

        public int count;

        public ShoppingCart(int capacity)
        {
            products = new Product[capacity];
            count = 0;
        }

        public void AddProduct(Product product)
        {
            if (count < products.Length)
            {
                products[count] = product;
                count++;
                Console.WriteLine($"Product {product.Name} added to the cart.");
            }
            else
            {
                Console.WriteLine("Shopping cart is full. Cannot add more products.");
            }

        }

        public void RemoveProduct(int productId)

        {
            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (products[i].ProductId == productId)
                {
                    Console.WriteLine($"Product{products[i].Name} removed from cart.");

                    for (int j = i; j < count - 1; j++)
                    {
                        products[j] = products[j + 1];
                    }
                    products[count - 1] = null;
                    count--;
                    found = true;
                    break;
                }
            }

                if (!found)
                {
                    Console.WriteLine("Product not found in cart.");

                }
            }
        


        public decimal CalculateTotalPrice()
        {
            decimal total = 0;
            for (int i = 0; i < count; i++)
            {
                total += products[i].Price;
            }

            return total;

        }

        public void DisplayCartContents()
        {
            Console.WriteLine("\n Shopping Cart Contents ");
            for (int i = 0; i< count; i++)
            {
                products[i].DisplayInfo();
            }
            Console.WriteLine($"Total Price: {CalculateTotalPrice():C}");
            Console.WriteLine("------------\n");
        }

    }
}







