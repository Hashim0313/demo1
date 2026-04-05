using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops2.Models
{
    internal class Book
    {
        public int Id;
        public string Title;
        public string Author;
        public int Publishedyear;

        public void DisplayInfo()
        {
            Console.WriteLine($"Book ID: {Id}");
            Console.WriteLine($"title: {Title}");
            Console.WriteLine($"author: {Author}");
            Console.WriteLine($"published year: {Publishedyear}");
        }

        public Book (int id, string title, string author, int publishedyear)
        {
           Id = id;
           Title = title;
           Author = author;
           Publishedyear = publishedyear;
        }

    }
}
