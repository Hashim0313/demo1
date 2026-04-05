using exercise_2.Manager;

public class Program
{
    private static void Main(string[] args)
    {
        JobManager jobManager = new JobManager();
        PublicManager publicManager = new PublicManager(jobManager);
        publicManager.DisplayMenu();
    }
}