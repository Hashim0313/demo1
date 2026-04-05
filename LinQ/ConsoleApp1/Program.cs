internal class Program
{
    private static void Main(string[] args)
    {
        List<int> scores = new List<int>
        {
            20,50,85,78,30,99,100,50,20,30,10
        };

        bool passed = scores.All(scores => scores > 40 );

        Console.WriteLine(passed);



        bool pass = scores.Any(scores => scores >= 40);
        Console.WriteLine(pass);




        List<int> numbers = new List<int>

        {
            1,2,2,3,4,4,5,6,5,3,2
        };

        var num = numbers.Distinct().ToList();
        Console.WriteLine(num);

    }


}