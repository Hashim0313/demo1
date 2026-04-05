using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using books.Models;
using books.Inteface;
using books.Enums;

namespace books.Manager
{
    public class BookManager : IManage
    {
        public static List<Book> books1 = new List<Book>();

        public void AddBook()
        {
            Console.WriteLine("\n enter book id ");
                int Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter title");
            string Title = Console.ReadLine();

            Console.WriteLine("enter Auther name");
            string Auther = Console.ReadLine();

            Console.WriteLine("\n\n");

            books1.Add(new Book(Id, Title, Auther));
        }



        public void GetBook()
        {
            foreach(var b in books1)
            {
                Console.WriteLine($"\n\n id : {b.Id}");
                Console.WriteLine($"\nTitle : {b.Title}");
                Console.WriteLine($"\nAuther : {b.Auther}\n\n");
            }
            
        }

    }


}
