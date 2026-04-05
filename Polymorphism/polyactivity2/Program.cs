using polyactivity2;

internal class Program
{
    public static void Main(string[] args)
    {
        User user = new User();
        user.Login();

        user = new Jobprovider();
        user.Login();

        user = new Jobseeker();
        user.Login();

    }
}