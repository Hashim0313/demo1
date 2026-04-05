using Polymorphismactivity.models;

internal class Program
{
    private static void Main(string[] args)
    {
        User user = new User();
        user.Login();
        user.Login("JohnDoe");
    }
}