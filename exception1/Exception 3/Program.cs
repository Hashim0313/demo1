using Exception_3.Exception;
using Exception_3.Models;
internal class Program
{
    private static void Main(string[] args)
    {
        User[] users = new User[4];
        int usercount = 0;

        while (true)
        {
            Console.WriteLine("choose an option \n 1 : Register \n 2 : Login \n 3 : Exit");
            string option = Console.ReadLine();

            if (option == "1")
            {
                try
                {
                    if (usercount >=users.Length)
                    {
                        Console.WriteLine("user limit reached");
                        continue;
                    }

                    Console.WriteLine("enter name");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter Email");
                    string email = Console.ReadLine();

                    for (int i = 0; i < usercount; i++)
                    {
                        if (users[i].Email == email)
                        {
                            throw new EmailAlreadyExcistsException("email id already exists");
                        }
                    }

                    Console.WriteLine("enter age");
                    int age = int.Parse(Console.ReadLine());

                    if (age <18)
                    {
                        throw new AgeException("age must be 18 or above");
                    }

                    users[usercount] = new User { Name = name, Email = email, Age = age };
                    usercount++;

                    Console.WriteLine("registration successful");
                    
                    }

                        catch (AgeException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                catch (EmailAlreadyExcistsException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Error occured : {ex.Message}");
                }
            }

            else if (option == "2")
            {
                Console.WriteLine("enter Email to login : ");

                string loginEmail = Console.ReadLine();

                bool foundUser = false;

                for (int i = 0; i < usercount; i++)
                {
                    if (users[i].Email == loginEmail)
                    {
                        foundUser = true;
                        Console.WriteLine("Login successful " + users[i].Name);
                        break;
                    }
                }

                if (!foundUser)
                {
                    Console.WriteLine("Email not found. login first");
                }
            }

            else if (option == "3")
            {
                Console.WriteLine("Exiting program");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }


                }
            }


        }

