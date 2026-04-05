namespace ProviderApp
{
    public class program
    {
        struct JobProvider
        {
            public string companyname;
            public string email;
            public string phone;
            public string password;
            public string jobrole;
            public string salary;
            public string experiencerequired;
        }

        static JobProvider[] jobprovider = new JobProvider[5];
        static JobProvider loggedinUser;
        static int userCount = 0;
        static void Main(string[] args)
        {

            string ch;
            do
            {
                Console.WriteLine("************************");
                Console.WriteLine("choose option");
                Console.WriteLine("1.login");
                Console.WriteLine("2.register");
                Console.WriteLine("************************");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Login();
                        break;

                    case "2":
                        Register();
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }


                Console.WriteLine("do you want to continue? (yes/no) (y/n)");
                ch = Console.ReadLine();
            }
            while (ch == "y" || ch == "Y");
        }
            


                static void Login()
                {
                    Console.WriteLine("**************************\n");

                    Console.WriteLine("enter email");
                    string email = Console.ReadLine();

                    Console.WriteLine("enter password");
                    string password = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("*****************************");

                    bool loginSuccessfull = false;

                    foreach (JobProvider jp in jobprovider)
                    {
                        if (jp.email == email && jp.password==password)
                        {
                            loginSuccessfull = true;
                            loggedinUser = jp;

                            Console.WriteLine("login successful");
                            Console.WriteLine();
                            Console.WriteLine("here are your datails");
                            Console.WriteLine("companyname : {0}", loggedinUser.companyname);
                            Console.WriteLine("email : {0}", loggedinUser.email);
                            Console.WriteLine("password : {0}", loggedinUser.password);
                            Console.WriteLine("salary : {0}", loggedinUser.salary);
                            Console.WriteLine("jobrole : {0}", jp.jobrole);
                            Console.WriteLine("experiencerequired : {0}", jp.experiencerequired);
                            Console.WriteLine("phone : {0}", jp.phone);
                            Console.WriteLine();

                        }
                    }

                }

                static void Register()
                {
                    JobProvider jobProvider = new JobProvider();

                    Console.WriteLine("**************************\n");
                    Console.WriteLine();
                    Console.WriteLine("enter companyname");
                    jobProvider.companyname = Console.ReadLine();

                    Console.WriteLine("enter email");
                    jobProvider.email = Console.ReadLine();

                    Console.WriteLine("enter phone");
                    jobProvider.phone = Console.ReadLine();

                    Console.WriteLine("enter password");
                    jobProvider.password = Console.ReadLine();

                    Console.WriteLine("enter jobrole");
                    jobProvider.jobrole = Console.ReadLine();

                    Console.WriteLine("enter salary");
                    jobProvider.salary = Console.ReadLine();

                    Console.WriteLine("enter experiencerequired");
                    jobProvider.experiencerequired = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine("*****************************");

                    jobprovider[userCount] = jobProvider;
                    userCount++;

                }







            }


        }
   