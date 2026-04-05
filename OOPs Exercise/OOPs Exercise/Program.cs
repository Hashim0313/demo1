using OOPs_Exercise.managers;

internal class Program
{
    public static void Main(string[] args)
    {
        
        JobSeekerManager jobSeekerManager = new JobSeekerManager();

        while (true)
        {
            Console.WriteLine("Job Portal System\n");
            Console.WriteLine("1. Register\n");
            Console.WriteLine("2. Login\n");
            Console.WriteLine("3. Exit\n");

            Console.WriteLine("Enter your choice: ");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1": jobSeekerManager.RegisterJobSeeker();
                    break;
                case "2": jobSeekerManager.LoginJobSeeker();
                    break;
                case "3": Console.WriteLine("Thank you");
                    Environment.Exit(0);
                    break;
                default:Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        
    }
}