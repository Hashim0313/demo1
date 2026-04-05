using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_generic.models
{
    public class LibraryManagementSystem
    {
        SortedDictionary<string, string> books = new SortedDictionary<string, string>();

        public void AddBook(string title, string ISBN)
        {
            if (!books.ContainsKey(ISBN))
            {
                books.Add(ISBN, title);
                Console.WriteLine($"Book '{title}' with ISBN '{ISBN}' added to the library.");
            }
            else
            {
                Console.WriteLine($"Book with ISBN '{ISBN}' already exists in the library.");
            }
        }


        Dictionary<int, string> Members = new Dictionary<int, string>();

        public void RegisterMember(int memberId, string memberName)
        {
            if (!Members.ContainsKey(memberId))
            {
                Members.Add(memberId, memberName);
                Console.WriteLine($"Member '{memberName}' with ID '{memberId}' registered.");
            }
            else
            {
                Console.WriteLine($"Member with ID '{memberId}' already exists.");
            }
        }

        Queue<string> CheckoutBook = new Queue<string>();

        public void CheckoutBooks(string title)
        {
            if (books.ContainsKey(title))
            {
                CheckoutBook.Enqueue(books[title]);
                books.Remove(title);
                Console.WriteLine($"Book with title '{title}' borrowed.");
            }
            else
            {
                Console.WriteLine($"Book with title '{title}' is not available.");
            }
        }

        Stack<string> ReturnBook = new Stack<string>();

        public void ReturnBooks(string title)
        {
            if (CheckoutBook.Count > 0)
            {
                string returnedBook = CheckoutBook.Dequeue();
                Console.WriteLine($" '{returnedBook}' returned.");
            }
        }


        List<string> Announcement = new List<string>();

        public void announcement(string message)
        {
            Announcement.Add(message);
            Console.WriteLine($"Announcement added: {message}");
        }


        public void Print()
        {
            Console.WriteLine("\nBooks in Library:");

            foreach (var book in books)
            {
                Console.WriteLine($"ISBN: {book.Key}, Title: {book.Value}");
            }




            Console.WriteLine("\nRegistered Members:");
            foreach (var member in Members)
            {
                Console.WriteLine($"ID: {member.Key}, Name: {member.Value}");
            }



            Console.WriteLine("\nChecked Out Books:");

            foreach (var book in CheckoutBook)
            {
                Console.WriteLine($"Title: {book}");
            }



            Console.WriteLine("\nAnnouncements:");
            foreach (var announcement in Announcement)
            {
                Console.WriteLine($"- {announcement}");
            }





        }
    }
}
