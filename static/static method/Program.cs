using static_method.models;

internal class Program
{
    private static void Main(string[] args)
    {
        int result = Calculator.Add(10, 20);
        Console.WriteLine(result);
    }
}