using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace books.Models
{
    public class Book
    {
        public int Id;
        public string Title;
        public string Auther;

        public Book(int id,string title, string auther)
        {
            Id = id;
            Title = title;
            Auther = auther;
        }

    }
}
