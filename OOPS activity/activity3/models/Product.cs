using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity3.models
{
    public class Product
    {

        public int ProductId;
        public string ProductName;
        public int Price;
        public int Quantity;

        public int Total;




        public void CalculateTotalPrice()
        {
            Total = Price * Quantity;

            Console.WriteLine($"product id : {ProductId} \n  {ProductName} \n price :  {Price} \n quantity : {Quantity} \n total = {Total} \n");
          
        }



        public Product(int id, string productname, int price, int quantity)
        {
            ProductId = id;
            ProductName = productname;
            Price = price;
            Quantity = quantity;
        }



    }
}
