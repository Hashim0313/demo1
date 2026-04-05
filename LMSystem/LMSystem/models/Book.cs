using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSystem.models
{
    public class Book
    {
        private int bookId;
        private string title;
        private string author;
        private int copiesAvailable;


        public Book(int BookId, string Title, string Author, int CopiesAvailable)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            CopiesAvailable = copiesAvailable;
        }

        public int BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }


        public string Title
        {
            get { return title; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    title = value;
                }
                else
                {
                    Console.WriteLine("Title cannot be empty");
                }
            }
        }


        public string Author
        {
            get { return author; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Author cannot be empty");
                }
            }
        }

        public int CopiesAvailable
        {
            get { return copiesAvailable; }
            set
            {
                if (value >= 0)
                {
                    copiesAvailable = value;
                }
                else
                {
                    Console.WriteLine("Copies available cannot be negative");
                }
            }
        }


        public class EBook : Book
        {
            public int fileSize;
            public string format;


            public EBook(int BookId, string Title, string Author, int CopiesAvailable, int FileSize, string Format)
                : base(BookId, Title, Author, CopiesAvailable)
            {
                FileSize = fileSize;
                Format = format;
            }
        }

        public class PrintedBook : Book
        {
            public int pages;
            public string publisher;

            public PrintedBook(int BookId, string Title, string Author, int CopiesAvailable, int Pages, string Publisher)
                : base(BookId, Title, Author, CopiesAvailable)
            {
                Pages = pages;
                Publisher = publisher;
            }

        }
    }
}
