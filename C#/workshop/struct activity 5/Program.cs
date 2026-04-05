internal class Program
{
    public struct  rectangle
    {
        public int length;
        public int width;
        public rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        public double CalculateArea()
        {
            return length * width;
        }
        


        public static void Main (string[] args)
        {
            rectangle r1 = new rectangle();
            Console.WriteLine("Enter the length of the rectangle:");
            r1.length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle:");
            r1.width = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine($"Area of the rectangle: {r1.CalculateArea()}");
        }



    }
}