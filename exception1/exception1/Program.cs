using exception1.Exception;
using System.Text.RegularExpressions;
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("enter phone number");
            string phonenumber = Console.ReadLine();


            ValidatePhoneNumber(phonenumber);
            Console.WriteLine("phone number is valid");
        }

        //catch (Exception ex)
        //{
        //    Console.WriteLine($"Error {ex.Message}");
        //}

        catch (InvalidPhoneNumberException ex)
        {
            Console.WriteLine($"error occured : {ex.Message}");
        }


    }

    public static void ValidatePhoneNumber(string phonenumber)
    {
        string pattern = @"^\+?[1-9]\d{9,14}$";

        if (!Regex.IsMatch(phonenumber,pattern))
        {
            throw new InvalidPhoneNumberException("invalid phone number format");
        }
    }
}