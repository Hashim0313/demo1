internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int>
        {
            10,20,30,40,50,60,70,81,92,
        };

        List<int> number2 = new List<int>
        {
            20,50,60,40,70,20,80,30,10,
        };

        var numb = numbers.Skip(3).Take(4);
        Console.WriteLine("numbers...");
        foreach(var num in numb)
        {
            Console.WriteLine(num);
        }


        var zipped = numbers.Zip(number2, (a, b) => a * b);

        Console.WriteLine("\n\nafter zipping numbers and number2");

        foreach(var n in zipped)
        {
            Console.WriteLine(n);
        }



        var agg = numbers.Aggregate((a, b) => a * b);

        Console.WriteLine(agg);



    }
}