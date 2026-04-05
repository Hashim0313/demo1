using Exception2.Exception;
using System.Text.RegularExpressions;
internal class Program
{
    private static void Main(string[] args)
    {

        try
        {
            Console.WriteLine("Enter email");
            string Email = Console.ReadLine();


            ValidateEmail(Email);
            Console.WriteLine("Email is valid");

        }
        catch(InvalidEmailException ex)
        {
            Console.WriteLine($"error occured {ex.Message}");
        }

    }


    public static void ValidateEmail(string Email)
    {
        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        if (!Regex.IsMatch(Email,pattern))
        {
            throw new InvalidEmailException($"Invalid Emil address : ");
        }
    }




}