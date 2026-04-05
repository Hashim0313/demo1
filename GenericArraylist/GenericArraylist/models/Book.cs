using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericArraylist.models
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void DisplayBook()
        {
                       Console.WriteLine($"Title: {Title}, Author: {Author}");
        }
    }



     class  Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book '{book.Title}' added to the library.");
        }

        public void RemoveBook(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    books.RemoveAt(i);
                    Console.WriteLine($"Book '{title}' removed from the library.");
                    return;
                }
            }
                Console.WriteLine($"Book '{title}' not found in the library.");
            }

            public void DisplayBooks()
            {
            if (books.Count == 0)
            { 
                Console.WriteLine("Books in the library:");
                return;
            }
            Console.WriteLine("Books in the library:");
            foreach (var book in books)
            {
                book.DisplayBook();
            }

        }
    }


}
