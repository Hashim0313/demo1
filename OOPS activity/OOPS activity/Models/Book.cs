using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_activity.Models
{
    public class Book
    {
        public int Id;
        public string Title;
        public string Auther;
        public int Price;

       
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Book ID: {Id} title: {Title} auther {Auther} price {Price}");
        }

        public Book(int id, string title, string auther, int price)
        {
            Id = id;
            Title = title;
            Auther = auther;
            Price = price;

        }

    }
}

