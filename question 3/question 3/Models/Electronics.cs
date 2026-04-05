using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_3.Models
{
    public class Electronics : Product
    {
        public double Price;
        public Electronics(int productid, string productname,double price) : base(productid, productname)
        {
            Price = price;
        }

        public void CalculateDiscount(double price)
        {
            double Discountamount = price * 10 / 100;

            double finalamount = price - Discountamount;

            
            Console.WriteLine($"\n\nProduct Id : {ProductId} \n Product name : {ProductName} \n Price : {price} (Discount rate 10%) \n Discount amount {Discountamount} \n Final Price {finalamount}\n");
        }
    }
}
