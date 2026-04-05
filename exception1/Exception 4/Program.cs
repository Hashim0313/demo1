using Exception_4.Exceptions;

internal class Program
{
    private static void Main(string[] args)
    {
        int num1, num2, sum=0;
        try
        {
            Console.WriteLine("enter 1st number");
             num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter 2nd number");
             num2 = Convert.ToInt32(Console.ReadLine());


             sum = num1 + num2;



            if (sum % 2 == 0)
            {
                Console.WriteLine(sum);
            }
            else
            {
                throw new OddNumberException("odd number caught");
            }


        }
        catch (OddNumberException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine(sum);
        }
   
    }
}