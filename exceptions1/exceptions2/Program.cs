internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            string[] pets = { "dog", "cat", "fish" };
            Console.WriteLine(pets[10]);
        }
        catch (IndexOutOfRangeException exc)
        {
            Console.WriteLine("exception occured" + exc.Message);
        }
        finally
        {
            Console.WriteLine("finally block executed");
        }
    }
}