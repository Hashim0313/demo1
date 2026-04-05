using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assesment.models
{
    public abstract class Product
    {
        public int ProductId;
        public string ProductName;


        public Product(int ProductId, string ProductName)
        {
            ProductId = ProductId;
            ProductName = ProductName;
        }
        public Product()
        {
        }

        public abstract double CalculateDiscount(double price);

    }



    public class Electronics : Product
    {
        public Electronics(int ProductId, string ProductName) : base(ProductId, ProductName)
        {
        }
        public Electronics()
        {
        }
        public override double CalculateDiscount(double price)
        {
            return price * 10/100 ;
        }



    }


    public class Clothing : Product
    {
        public Clothing(int ProductId, string ProductName) : base(ProductId, ProductName)
        {
        }
        public Clothing()
        {
        }
        public override double CalculateDiscount(double price)
        {
            return  price * 20/100 ;
        }




    }
}
