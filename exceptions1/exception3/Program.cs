internal class Program
{
    private static void Main(string[] args)
    {
       try
        {
            int i = int.MaxValue;
            int j = checked(i + 1);
            Console.WriteLine(j);
        }
        catch (OverflowException exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}