using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_3.Models
{
    public class Product
    {
        public int ProductId;
        public string ProductName;
        
      
        public Product (int productid, string productname)
        {
            ProductId = productid;
            ProductName = productname;
        }

       public void CalculateDiscount(double price)
        {
           
        }
    }
}
