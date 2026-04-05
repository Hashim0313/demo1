using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_activity.models
{
    public abstract class Product
    {
        public string Name;
        public int Id;
        public decimal Price;
        public int ProductId;

        public Product(string name, int id, decimal price)
        {
            Name = name;
            Id = id;
            Price = price;
        }

        public abstract void DisplayInfo();
    
    }

    public class ElectronicProduct : Product
    {
      
        public int warrantyPeriod;


        public ElectronicProduct(string name, int id, decimal price, string brand, int warrantyPeriod) : base (name, id,price)
        {
            Name = name;
            Id = id;
            Price = price;
          
            this.warrantyPeriod = warrantyPeriod;
        }



        public override void DisplayInfo()
        {
            Console.WriteLine($"Electronic Product - Name: {Name}, Id: {Id}, Price: {Price:C},  Warranty Period: {warrantyPeriod} months");
        }

}


    public class GroceryProduct : Product
    {
        public DateTime expirationDate;


        public GroceryProduct(string name, int id, decimal price, DateTime expirationDate) : base (name, id, price)
        {
            Name = name;
            Id = id;
            this.Price = price;
            this.expirationDate = expirationDate;
        }





        public override void DisplayInfo()
        {
            Console.WriteLine($"Grocery Product - Name: {Name}, Id: {Id}, Price: {Price:C}, Expiration Date: {expirationDate}");
        }
    }
}

