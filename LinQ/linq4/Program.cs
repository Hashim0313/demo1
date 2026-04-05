internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int>
        {
            5,4,7,2,1,6,9,8,3,
        };

        numbers.Sort();
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }


        var descend = numbers. OrderByDescending()


    }
}