using application_exception2.Exceptions;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter phone no.");
            string phoneNumber = Console.ReadLine();

            ValidatePhoneNumber(phoneNumber);
            Console.WriteLine("valid phone number.");
        }
        //catch (InvalidPhoneNumberException ex)
        //{
        //    Console.WriteLine($"error :  {ex.Message}");
        //}

        catch (Exception ex)
        {
                       Console.WriteLine($"Invalid phone number: {ex.Message}");
        }
      
    }
    public static void ValidatePhoneNumber(string PhoneNumber)
    {
        string pattern = @"^\+?[1-9]\d{9,14}$";
        if (!Regex.IsMatch(PhoneNumber, pattern))
        {
            throw new InvalidPhoneNumberException("invalid phone number formate.");
        }
    }
}