internal class Program
{
    private static void Main(string[] args)
    {
        int result = 0;
        try
        {
            Console.WriteLine("enter first number");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number");
            int j = Convert.ToInt32(Console.ReadLine());

             result = i / j;
            Console.WriteLine("result: " + result);
        }

        catch (DivideByZeroException exception)
        {
            Console.WriteLine(exception.Message);
        }

        finally
        {
            Console.WriteLine("result = 0", result );
        }
    }
}