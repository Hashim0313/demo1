using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        private int bookId;
        private string title;
        private string author;
        private int copiesAvailable;


        public Book(int BookId, string Title, string Author, int CopiesAvailable)
        {
            bookId = BookId;
            title = Title;
            author = Author;
            copiesAvailable = CopiesAvailable;
        }

        public int BookID
        {
            get { return bookId; }
            set { bookId = value; }
        }

        public string TiTle
        {
            get { return title; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    TiTle = value;
                }
                else
                {
                    Console.WriteLine("Title cannot be empty");
                }

            }
        }


        public string AuThor
        {
            get { return author; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    AuThor = value;
                }
                else
                {
                    Console.WriteLine("Author cannot be empty");
                }
            }
        }

        public int CopiesAvailablE
        {
            get { return copiesAvailable; }
            set
            {
                if (value >= 0)
                {
                    CopiesAvailablE = value;
                }
                else
                {
                    Console.WriteLine("Copies cannot be negative.");
                }
            }
        }


        public class EBook : Book
        {
            public int fileSize;
            public string format;

            public EBook(int booKId, string title, string author, int copiesAvailabe, int FileSize, string Format) : base(booKId, title, author, copiesAvailabe)
            {
                fileSize = FileSize;
                format = Format;
            }
        }

        public class PrintedBook : Book
        {
            public int pages;
            public string publisher;

            public PrintedBook(int bookID, string title, string author, int copiesAvailable, int Pages, string Publisher) : base(bookID, title, author, copiesAvailable)
            {
                pages = Pages;
                publisher = Publisher;
            }
        }




    }
}