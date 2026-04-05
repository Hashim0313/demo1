internal class Program
{
    public struct book
    {
        public string title;
        public string author;
        public float price;

        public book(string title, string author, float price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }


        public void DisplayDetails()
        {
            Console.WriteLine($"Title: {title}, Author: {author}, Price: {price:C}");
        }


        public static void Main(string[] args)
        {
            book b1 = new book();
            b1.title = "book1";
            b1.author = "jon";
            b1.price = 499;



            book b2 = new book();
            b2.title = "book2";
            b2.author = "arya";
            b2.price = 599;



            book b3 = new book();
            b3.title = "book3";
            b3.author = "robb";
            b3.price = 399;



            b1.DisplayDetails();
            b2.DisplayDetails();
            b3.DisplayDetails();




            Console.WriteLine("\nBooks priced below 500:\n");

            if (b1.price < 500)
            {
                Console.WriteLine($"{b1.title}");
            }
             if (b2.price < 500)
            {
                Console.WriteLine($"{b2.title}");
            }
             if (b3.price < 500)
            {
                Console.WriteLine($"{b3.title}");
            }




        }
    }
}