internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int>
        {
            1, 2,3,4,5,6,7,8,9,
        };

        

        var num = numbers.Where(x => x % 2 == 0);
        foreach(var x in num)
        {
            Console.WriteLine(x);
        }

        int numb = numbers.FirstOrDefault(x => x % 2 == 0);
        
            Console.WriteLine("\n first number"+numb);



        int numbe = numbers.LastOrDefault(x => x % 2 == 0);

        Console.WriteLine("last number" + numbe);
        

    }
}