using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_activity.models
{
    internal class LibraryManagement
    {
        SortedList<string, string> books = new SortedList<string, string>();

        public void AddBook()
        {
            Console.WriteLine("Enter Book Title:");
            string title = Console.ReadLine();
            Console.WriteLine("Enter Book ISBN:");
            string ISBN = Console.ReadLine();
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

        public void RegisterMember()
        {
            Console.WriteLine("Enter Member ID:");
            int memberId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Member Name:");
            string memberName = Console.ReadLine();
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

        public void CheckoutBooks()
        {
            Console.WriteLine("Enter Book Title to Checkout:");
            string title = Console.ReadLine();
            if (books.ContainsValue(title))
            {
                var bookEntry = books.FirstOrDefault(x => x.Value == title);
                CheckoutBook.Enqueue(bookEntry.Value);
                books.Remove(bookEntry.Key);
                Console.WriteLine($"Book with title '{title}' borrowed.");
            }
            else
            {
                Console.WriteLine($"Book with title '{title}' is not available.");
            }
        }

        Stack<string> ReturnBook = new Stack<string>();
        public void ReturnBooks()
        {
            Console.WriteLine("Enter Book Title to Return:");
            string title = Console.ReadLine();
            if (CheckoutBook.Contains(title))
            {
                ReturnBook.Push(title);
                CheckoutBook = new Queue<string>(CheckoutBook.Where(b => b != title));
                Console.WriteLine($"Book with title '{title}' returned.");
            }
            else
            {
                Console.WriteLine($"Book with title '{title}' was not borrowed from this library.");
            }
        }

        List<string>announcements = new List<string>();


        public void MakeAnnouncement()
        {
            Console.WriteLine("Enter Announcement:");
            string announcement = Console.ReadLine();
            announcements.Add(announcement);
            Console.WriteLine("Announcement made.");
        }

        public void Print()
        {
            Console.WriteLine("Books in Library:");

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


            Console.WriteLine("\nReturned Books:");
            foreach (var book in ReturnBook)
            {
                Console.WriteLine($"Title: {book}");
            }



            Console.WriteLine("\nAnnouncements:");
            foreach (var announcement in announcements)
            {
                Console.WriteLine(announcement);
            }




        }
    }
}
