using Application_Exception_3.Exception;
using Application_Exception_3.models;

internal class Program
{
    private static void Main(string[] args)
    {
        User[] users = new User[5];
        int usercount = 0;

        while (true)
        {
            Console.WriteLine(("Choose an option:\n1. Register\n2. Login\n3. Exit");
            string option = Console.ReadLine();

            if (option =="1")
            {
                try
                {
                    if (usercount>= users.Length)
                    {
                        Console.WriteLine("Enter Email");
                        string name = Console.ReadLine();

                        Console.WriteLine("enter email");
                        string email = Console.ReadLine();

                        for (int i = 0;i<usercount; i++)
                        {
                            if (users[i].Email==email)
                            {
                                throw new EmailAlreadyExistException("Email id already exists. please use a different one ");

                            }
                        }
                        Console.WriteLine("enter age:");
                        int age = int.Parse(Console.ReadLine());

                        if (age<18)
                        {
                            throw new AgeException("you must be atlest 18 years old to register");

                        }

                        users[usercount]
                    }
                }
            }

        }
    }
}