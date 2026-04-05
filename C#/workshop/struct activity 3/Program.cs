internal class Program
{
    public struct Product
    {
        public int id;
        public string name;
        public decimal price;

        public Product(int id, string name, decimal price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public void DisplaDetails()
        {
             Console.WriteLine($"{id} - {name} - {price:C}");
        }

        private static void Main(string[]args)
        {
            Product p1 = new Product();
            p1.id = 1;
            p1.name = "Laptop";
            p1.price = 75000;

            p1.DisplaDetails();


        }
    }
}