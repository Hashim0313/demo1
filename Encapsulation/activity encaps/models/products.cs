using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_encaps.models
{
    public class Products
    {
        private int ProductId;
        private string _Name;
        private int _Price;
        private int _StockQuantity;


        public Products(int productId, string name, int price, int stockQuantity)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;

        }


        public int ProductId
        {
            get { return ProductId; }
            set
            {
                if (value > 0)
                    ProductId = value;
                else
                    Console.WriteLine("Product ID must be positive.");
            }
        }

        public string Name
        {
            get { return Name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    Name = value;
                else
                    Console.WriteLine("Name cannot be empty.");
            }
        }

        public int Price
        {
            get { return Price; }
            set
            {
                if (value >= 0)
                    Price = value;
                else
                    Console.WriteLine("Price cannot be negative.");
            }
        }

        public int StockQuantity
        {
            get { return StockQuantity; }
            set
            {
                if (value >= 0)
                    StockQuantity = value;
                else
                    Console.WriteLine("Stock quantity cannot be negative.");
            }
        }
    }


        public class ElectronicProduct : Products
        {
            public int WarrantyPeriod;
            public string Brand;

            public ElectronicProduct(int productId, string name, int price, int stockQuantity, int warrantyPeriod, string brand)
                : base(productId, name, price, stockQuantity)
            {
                WarrantyPeriod = warrantyPeriod;
                Brand = brand;
            }


        }


        public class ClothingProduct : Products
        {
            public int Size;
            public string Material;

            public ClothingProduct(int productId, string name,int price, int stockQuantity, int size, string material) 
                : base(productId,name, price, stockQuantity)
            {
                Size = size;
                Material = material;
            }
        }


        public abstract class  Order 
        {
           public  int OrderId;
            public string CustomerName;
            public DateTime OrderDate;


            public Order (int orderId, string customerName, DateTime orderDate)
            {
                OrderId = orderId;
                CustomerName = customerName;
                OrderDate = orderDate;
            }
            public abstract void CalculateTotal();




            public class OnlineOrder : Order
            {

                public OnlineOrder(int orderId, string customerName, DateTime orderDate)
                    : base(orderId, customerName, orderDate)
                {

                }




                public override void CalculateTotal()
                {
                    CalculateTotal();
                }
            }
        }



    

}
