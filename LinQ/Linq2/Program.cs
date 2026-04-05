internal class Program
{
    public static void Main(string[] args)
    {
        int[] number =
        {
            10,20,30,4,50,60,70,1,3,5,7
        };

        //var num = from n in number
        //          where n % 2 == 0
        //          select n;

        //foreach(var n in num)
        //{
        //    Console.WriteLine("even numbers" + n);
        //}

        //var numb = from n in number
        //           where n % 2 != 0
        //           select n;
        //foreach (var n in numb)
        //{
        //    Console.WriteLine("odd numbers" + n);
        //}

        var result=number.Where(x => x % 2 == 0);

        foreach(var x in result )
        {
            Console.WriteLine("\n even numbers");
            Console.WriteLine(x);
        }

        var result1 = number.Where(x => x % 2 != 0);

        foreach (var x in result1)
        {
            Console.WriteLine("\nodd numbers");
            Console.WriteLine(x);
        }

    }
}