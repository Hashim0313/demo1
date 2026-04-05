using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_3.Models
{
    public class Clothing : Product
    {
        public double price;
        public Clothing(int productid, string productname, double Price) : base(productid, productname)
        {
            Price = price;
        }
        public void CalculateDiscount(double price)
        {
            double Discountamount = price * 20 / 100;

            double finalamount = price - Discountamount;

            Console.WriteLine($"\nProduct name : {ProductId} \n Product name : {ProductName} \n Price : {price}   (Discount rate : 20% )\n Discount amount {Discountamount} \n Final Price {finalamount} \n");
        }
    }
}
