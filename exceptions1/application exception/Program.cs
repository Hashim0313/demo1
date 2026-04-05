using application_exception;
using application_exception.Exception;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("enter email : ");
            string email = Console.ReadLine();

            EmailValidator.ValidateEmail(email);
            Console.WriteLine("valid email.");
        }
        catch (InvalidEmailExcp ex)
        {
            Console.WriteLine($"Invalid email: {ex.Message}");
        }

    }
   
}